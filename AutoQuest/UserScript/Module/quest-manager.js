// ==UserScript==
// @match        http://wars.fm/reversi*
// ==/UserScript==

(function () {
    'use strict';

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
        }
    };

    // 定期コール
    setInterval(function () {
        if ($("#game").css('display') !== 'none')
            $("#play-again-button").click();
    }, 1000);
})();