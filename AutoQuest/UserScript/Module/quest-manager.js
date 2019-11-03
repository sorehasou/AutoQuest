// ==UserScript==
// @match        http://wars.fm/reversi*
// ==/UserScript==

(function () {
    'use strict';

    // JQuery 未インストール時は実行しない
    if ($ !== jQuery) return;

    var lastMove = '';
    var element = $("#lastmove").get(0);

    // DOM変更時
    new MutationObserver(function () {
        var _lastMove = element.innerText;
        if (lastMove !== _lastMove) {
            lastMove = _lastMove;
            var isMe = $(".player0.turn-to-play").length !== 1;
            if (isMe === false) {
                var play = lastMove.split('. ')[1];
                autoQuest.play(play);
            }
        }
    }).observe(element, {
        childList: true
    });

    // ハッシュ変更時
    window.onhashchange = function () {
        var hash = location.hash;

        if (hash.indexOf('#game/') >= 0) {
            // 自身が先攻の場合は 1、そうでない場合は 0
            var mode = $(".player0 .name.turn0").length === 1 ? 1 : 0;
            autoQuest.startOthello(mode);

            if ($('.mask').length === 0) {
                var mask = $('<div class=mask />');
                mask.css({
                    'position': 'absolute',
                    'top': 0,
                    'right': 0,
                    'bottom': 0,
                    'left': 0,
                    'background-color': 'rgba(27, 0, 255, 0.32)',
                    'z-index': 100
                });
                var text = $('<div>自動操作中</div>');
                text.css({
                    'position': 'absolute',
                    'top': '50%',
                    'left': '50%',
                    'transform': 'translate(-50%, -50%)',
                    'font-size': '60px',
                    'white-space': 'nowrap',
                    'font-weight': 'bold',
                    'color': 'white',
                    'background-color': 'rgba(0, 0, 0, 0.55)'
                });
                mask.append(text);
                $('#screen').append(mask);
            }
        }
    };
    
    // 定期コール
    (function timer() {
        if ($("#game").css('display') !== 'none')
            $("#play-again-button").click();

        $('#apps,#sns,#i18n').hide();
        $('#screen').css({
            'position': 'absolute',
            'top': '50%',
            'left': '50%',
            'transform': 'translate(-50%, -50%)',
            'width': '500px'
        });

        setTimeout(timer, 1000);
    })();
})();