@charset "UTF-8";
/*  SASS libraries ------------------------------------ */
/*  when you are using rotate this hides the backface to prevent pixellation
    along the element edge.  The two states are 'hidden' and default 'visible' */
/*  rotate in degrees with the numeric first and then the 'deg' after 
    of the format XXdeg */
/*  Linear gradient.  A bit cobbled together but should work for basic top to 
    bottom linear gradients */
/*  MIXINS for general styles -------------------------------- */
/*  CSS and SASS from other project and third party  -- */
/*!
 *  Font Awesome 4.2.0 by @davegandy - http://fontawesome.io - @fontawesome
 *  License - http://fontawesome.io/license (Font: SIL OFL 1.1, CSS: MIT License)
 */
/* FONT PATH
 * -------------------------- */
@import url("font-awesome.css");
@import url("responsive");
@font-face {
  font-family: 'FontAwesome';
  src: url("../fonts/fontawesome-webfont.eot?v=4.2.0");
  src: url("../fonts/fontawesome-webfont.eot?#iefix&v=4.2.0") format("embedded-opentype"), url("../fonts/fontawesome-webfont.woff?v=4.2.0") format("woff"), url("../fonts/fontawesome-webfont.ttf?v=4.2.0") format("truetype"), url("../fonts/fontawesome-webfont.svg?v=4.2.0#fontawesomeregular") format("svg");
  font-weight: normal;
  font-style: normal; }
.fa {
  display: inline-block;
  font: normal normal normal 14px/1 FontAwesome;
  font-size: inherit;
  text-rendering: auto;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale; }

/* makes the font 33% larger relative to the icon container */
.fa-lg {
  font-size: 1.33333333em;
  line-height: 0.75em;
  vertical-align: -15%; }

.fa-2x {
  font-size: 2em; }

.fa-3x {
  font-size: 3em; }

.fa-4x {
  font-size: 4em; }

.fa-5x {
  font-size: 5em; }

.fa-fw {
  width: 1.28571429em;
  text-align: center; }

.fa-ul {
  padding-left: 0;
  margin-left: 2.14285714em;
  list-style-type: none; }

.fa-ul > li {
  position: relative; }

.fa-li {
  position: absolute;
  left: -2.14285714em;
  width: 2.14285714em;
  top: 0.14285714em;
  text-align: center; }

.fa-li.fa-lg {
  left: -1.85714286em; }

.fa-border {
  padding: .2em .25em .15em;
  border: solid 0.08em #eeeeee;
  border-radius: .1em; }

.pull-right {
  float: right; }

.pull-left {
  float: left; }

.fa.pull-left {
  margin-right: .3em; }

.fa.pull-right {
  margin-left: .3em; }

.fa-spin {
  -webkit-animation: fa-spin 2s infinite linear;
  animation: fa-spin 2s infinite linear; }

@-webkit-keyframes fa-spin {
  0% {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg); }
  100% {
    -webkit-transform: rotate(359deg);
    transform: rotate(359deg); } }
@keyframes fa-spin {
  0% {
    -webkit-transform: rotate(0deg);
    transform: rotate(0deg); }
  100% {
    -webkit-transform: rotate(359deg);
    transform: rotate(359deg); } }
.fa-rotate-90 {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=1);
  -webkit-transform: rotate(90deg);
  -ms-transform: rotate(90deg);
  transform: rotate(90deg); }

.fa-rotate-180 {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=2);
  -webkit-transform: rotate(180deg);
  -ms-transform: rotate(180deg);
  transform: rotate(180deg); }

.fa-rotate-270 {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=3);
  -webkit-transform: rotate(270deg);
  -ms-transform: rotate(270deg);
  transform: rotate(270deg); }

.fa-flip-horizontal {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=0, mirror=1);
  -webkit-transform: scale(-1, 1);
  -ms-transform: scale(-1, 1);
  transform: scale(-1, 1); }

.fa-flip-vertical {
  filter: progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1);
  -webkit-transform: scale(1, -1);
  -ms-transform: scale(1, -1);
  transform: scale(1, -1); }

:root .fa-rotate-90,
:root .fa-rotate-180,
:root .fa-rotate-270,
:root .fa-flip-horizontal,
:root .fa-flip-vertical {
  filter: none; }

.fa-stack {
  position: relative;
  display: inline-block;
  width: 2em;
  height: 2em;
  line-height: 2em;
  vertical-align: middle; }

.fa-stack-1x,
.fa-stack-2x {
  position: absolute;
  left: 0;
  width: 100%;
  text-align: center; }

.fa-stack-1x {
  line-height: inherit; }

.fa-stack-2x {
  font-size: 2em; }

.fa-inverse {
  color: #ffffff; }

/* Font Awesome uses the Unicode Private Use Area (PUA) to ensure screen
   readers do not read off random characters that represent icons */
.fa-glass:before {
  content: "\f000"; }

.fa-music:before {
  content: "\f001"; }

.fa-search:before {
  content: "\f002"; }

.fa-envelope-o:before {
  content: "\f003"; }

.fa-heart:before {
  content: "\f004"; }

.fa-star:before {
  content: "\f005"; }

.fa-star-o:before {
  content: "\f006"; }

.fa-user:before {
  content: "\f007"; }

.fa-film:before {
  content: "\f008"; }

.fa-th-large:before {
  content: "\f009"; }

.fa-th:before {
  content: "\f00a"; }

.fa-th-list:before {
  content: "\f00b"; }

.fa-check:before {
  content: "\f00c"; }

.fa-remove:before,
.fa-close:before,
.fa-times:before {
  content: "\f00d"; }

.fa-search-plus:before {
  content: "\f00e"; }

.fa-search-minus:before {
  content: "\f010"; }

.fa-power-off:before {
  content: "\f011"; }

.fa-signal:before {
  content: "\f012"; }

.fa-gear:before,
.fa-cog:before {
  content: "\f013"; }

.fa-trash-o:before {
  content: "\f014"; }

.fa-home:before {
  content: "\f015"; }

.fa-file-o:before {
  content: "\f016"; }

.fa-clock-o:before {
  content: "\f017"; }

.fa-road:before {
  content: "\f018"; }

.fa-download:before {
  content: "\f019"; }

.fa-arrow-circle-o-down:before {
  content: "\f01a"; }

.fa-arrow-circle-o-up:before {
  content: "\f01b"; }

.fa-inbox:before {
  content: "\f01c"; }

.fa-play-circle-o:before {
  content: "\f01d"; }

.fa-rotate-right:before,
.fa-repeat:before {
  content: "\f01e"; }

.fa-refresh:before {
  content: "\f021"; }

.fa-list-alt:before {
  content: "\f022"; }

.fa-lock:before {
  content: "\f023"; }

.fa-flag:before {
  content: "\f024"; }

.fa-headphones:before {
  content: "\f025"; }

.fa-volume-off:before {
  content: "\f026"; }

.fa-volume-down:before {
  content: "\f027"; }

.fa-volume-up:before {
  content: "\f028"; }

.fa-qrcode:before {
  content: "\f029"; }

.fa-barcode:before {
  content: "\f02a"; }

.fa-tag:before {
  content: "\f02b"; }

.fa-tags:before {
  content: "\f02c"; }

.fa-book:before {
  content: "\f02d"; }

.fa-bookmark:before {
  content: "\f02e"; }

.fa-print:before {
  content: "\f02f"; }

.fa-camera:before {
  content: "\f030"; }

.fa-font:before {
  content: "\f031"; }

.fa-bold:before {
  content: "\f032"; }

.fa-italic:before {
  content: "\f033"; }

.fa-text-height:before {
  content: "\f034"; }

.fa-text-width:before {
  content: "\f035"; }

.fa-align-left:before {
  content: "\f036"; }

.fa-align-center:before {
  content: "\f037"; }

.fa-align-right:before {
  content: "\f038"; }

.fa-align-justify:before {
  content: "\f039"; }

.fa-list:before {
  content: "\f03a"; }

.fa-dedent:before,
.fa-outdent:before {
  content: "\f03b"; }

.fa-indent:before {
  content: "\f03c"; }

.fa-video-camera:before {
  content: "\f03d"; }

.fa-photo:before,
.fa-image:before,
.fa-picture-o:before {
  content: "\f03e"; }

.fa-pencil:before {
  content: "\f040"; }

.fa-map-marker:before {
  content: "\f041"; }

.fa-adjust:before {
  content: "\f042"; }

.fa-tint:before {
  content: "\f043"; }

.fa-edit:before,
.fa-pencil-square-o:before {
  content: "\f044"; }

.fa-share-square-o:before {
  content: "\f045"; }

.fa-check-square-o:before {
  content: "\f046"; }

.fa-arrows:before {
  content: "\f047"; }

.fa-step-backward:before {
  content: "\f048"; }

.fa-fast-backward:before {
  content: "\f049"; }

.fa-backward:before {
  content: "\f04a"; }

.fa-play:before {
  content: "\f04b"; }

.fa-pause:before {
  content: "\f04c"; }

.fa-stop:before {
  content: "\f04d"; }

.fa-forward:before {
  content: "\f04e"; }

.fa-fast-forward:before {
  content: "\f050"; }

.fa-step-forward:before {
  content: "\f051"; }

.fa-eject:before {
  content: "\f052"; }

.fa-chevron-left:before {
  content: "\f053"; }

.fa-chevron-right:before {
  content: "\f054"; }

.fa-plus-circle:before {
  content: "\f055"; }

.fa-minus-circle:before {
  content: "\f056"; }

.fa-times-circle:before {
  content: "\f057"; }

.fa-check-circle:before {
  content: "\f058"; }

.fa-question-circle:before {
  content: "\f059"; }

.fa-info-circle:before {
  content: "\f05a"; }

.fa-crosshairs:before {
  content: "\f05b"; }

.fa-times-circle-o:before {
  content: "\f05c"; }

.fa-check-circle-o:before {
  content: "\f05d"; }

.fa-ban:before {
  content: "\f05e"; }

.fa-arrow-left:before {
  content: "\f060"; }

.fa-arrow-right:before {
  content: "\f061"; }

.fa-arrow-up:before {
  content: "\f062"; }

.fa-arrow-down:before {
  content: "\f063"; }

.fa-mail-forward:before,
.fa-share:before {
  content: "\f064"; }

.fa-expand:before {
  content: "\f065"; }

.fa-compress:before {
  content: "\f066"; }

.fa-plus:before {
  content: "\f067"; }

.fa-minus:before {
  content: "\f068"; }

.fa-asterisk:before {
  content: "\f069"; }

.fa-exclamation-circle:before {
  content: "\f06a"; }

.fa-gift:before {
  content: "\f06b"; }

.fa-leaf:before {
  content: "\f06c"; }

.fa-fire:before {
  content: "\f06d"; }

.fa-eye:before {
  content: "\f06e"; }

.fa-eye-slash:before {
  content: "\f070"; }

.fa-warning:before,
.fa-exclamation-triangle:before {
  content: "\f071"; }

.fa-plane:before {
  content: "\f072"; }

.fa-calendar:before {
  content: "\f073"; }

.fa-random:before {
  content: "\f074"; }

.fa-comment:before {
  content: "\f075"; }

.fa-magnet:before {
  content: "\f076"; }

.fa-chevron-up:before {
  content: "\f077"; }

.fa-chevron-down:before {
  content: "\f078"; }

.fa-retweet:before {
  content: "\f079"; }

.fa-shopping-cart:before {
  content: "\f07a"; }

.fa-folder:before {
  content: "\f07b"; }

.fa-folder-open:before {
  content: "\f07c"; }

.fa-arrows-v:before {
  content: "\f07d"; }

.fa-arrows-h:before {
  content: "\f07e"; }

.fa-bar-chart-o:before,
.fa-bar-chart:before {
  content: "\f080"; }

.fa-twitter-square:before {
  content: "\f081"; }

.fa-facebook-square:before {
  content: "\f082"; }

.fa-camera-retro:before {
  content: "\f083"; }

.fa-key:before {
  content: "\f084"; }

.fa-gears:before,
.fa-cogs:before {
  content: "\f085"; }

.fa-comments:before {
  content: "\f086"; }

.fa-thumbs-o-up:before {
  content: "\f087"; }

.fa-thumbs-o-down:before {
  content: "\f088"; }

.fa-star-half:before {
  content: "\f089"; }

.fa-heart-o:before {
  content: "\f08a"; }

.fa-sign-out:before {
  content: "\f08b"; }

.fa-linkedin-square:before {
  content: "\f08c"; }

.fa-thumb-tack:before {
  content: "\f08d"; }

.fa-external-link:before {
  content: "\f08e"; }

.fa-sign-in:before {
  content: "\f090"; }

.fa-trophy:before {
  content: "\f091"; }

.fa-github-square:before {
  content: "\f092"; }

.fa-upload:before {
  content: "\f093"; }

.fa-lemon-o:before {
  content: "\f094"; }

.fa-phone:before {
  content: "\f095"; }

.fa-square-o:before {
  content: "\f096"; }

.fa-bookmark-o:before {
  content: "\f097"; }

.fa-phone-square:before {
  content: "\f098"; }

.fa-twitter:before {
  content: "\f099"; }

.fa-facebook:before {
  content: "\f09a"; }

.fa-github:before {
  content: "\f09b"; }

.fa-unlock:before {
  content: "\f09c"; }

.fa-credit-card:before {
  content: "\f09d"; }

.fa-rss:before {
  content: "\f09e"; }

.fa-hdd-o:before {
  content: "\f0a0"; }

.fa-bullhorn:before {
  content: "\f0a1"; }

.fa-bell:before {
  content: "\f0f3"; }

.fa-certificate:before {
  content: "\f0a3"; }

.fa-hand-o-right:before {
  content: "\f0a4"; }

.fa-hand-o-left:before {
  content: "\f0a5"; }

.fa-hand-o-up:before {
  content: "\f0a6"; }

.fa-hand-o-down:before {
  content: "\f0a7"; }

.fa-arrow-circle-left:before {
  content: "\f0a8"; }

.fa-arrow-circle-right:before {
  content: "\f0a9"; }

.fa-arrow-circle-up:before {
  content: "\f0aa"; }

.fa-arrow-circle-down:before {
  content: "\f0ab"; }

.fa-globe:before {
  content: "\f0ac"; }

.fa-wrench:before {
  content: "\f0ad"; }

.fa-tasks:before {
  content: "\f0ae"; }

.fa-filter:before {
  content: "\f0b0"; }

.fa-briefcase:before {
  content: "\f0b1"; }

.fa-arrows-alt:before {
  content: "\f0b2"; }

.fa-group:before,
.fa-users:before {
  content: "\f0c0"; }

.fa-chain:before,
.fa-link:before {
  content: "\f0c1"; }

.fa-cloud:before {
  content: "\f0c2"; }

.fa-flask:before {
  content: "\f0c3"; }

.fa-cut:before,
.fa-scissors:before {
  content: "\f0c4"; }

.fa-copy:before,
.fa-files-o:before {
  content: "\f0c5"; }

.fa-paperclip:before {
  content: "\f0c6"; }

.fa-save:before,
.fa-floppy-o:before {
  content: "\f0c7"; }

.fa-square:before {
  content: "\f0c8"; }

.fa-navicon:before,
.fa-reorder:before,
.fa-bars:before {
  content: "\f0c9"; }

.fa-list-ul:before {
  content: "\f0ca"; }

.fa-list-ol:before {
  content: "\f0cb"; }

.fa-strikethrough:before {
  content: "\f0cc"; }

.fa-underline:before {
  content: "\f0cd"; }

.fa-table:before {
  content: "\f0ce"; }

.fa-magic:before {
  content: "\f0d0"; }

.fa-truck:before {
  content: "\f0d1"; }

.fa-pinterest:before {
  content: "\f0d2"; }

.fa-pinterest-square:before {
  content: "\f0d3"; }

.fa-google-plus-square:before {
  content: "\f0d4"; }

.fa-google-plus:before {
  content: "\f0d5"; }

.fa-money:before {
  content: "\f0d6"; }

.fa-caret-down:before {
  content: "\f0d7"; }

.fa-caret-up:before {
  content: "\f0d8"; }

.fa-caret-left:before {
  content: "\f0d9"; }

.fa-caret-right:before {
  content: "\f0da"; }

.fa-columns:before {
  content: "\f0db"; }

.fa-unsorted:before,
.fa-sort:before {
  content: "\f0dc"; }

.fa-sort-down:before,
.fa-sort-desc:before {
  content: "\f0dd"; }

.fa-sort-up:before,
.fa-sort-asc:before {
  content: "\f0de"; }

.fa-envelope:before {
  content: "\f0e0"; }

.fa-linkedin:before {
  content: "\f0e1"; }

.fa-rotate-left:before,
.fa-undo:before {
  content: "\f0e2"; }

.fa-legal:before,
.fa-gavel:before {
  content: "\f0e3"; }

.fa-dashboard:before,
.fa-tachometer:before {
  content: "\f0e4"; }

.fa-comment-o:before {
  content: "\f0e5"; }

.fa-comments-o:before {
  content: "\f0e6"; }

.fa-flash:before,
.fa-bolt:before {
  content: "\f0e7"; }

.fa-sitemap:before {
  content: "\f0e8"; }

.fa-umbrella:before {
  content: "\f0e9"; }

.fa-paste:before,
.fa-clipboard:before {
  content: "\f0ea"; }

.fa-lightbulb-o:before {
  content: "\f0eb"; }

.fa-exchange:before {
  content: "\f0ec"; }

.fa-cloud-download:before {
  content: "\f0ed"; }

.fa-cloud-upload:before {
  content: "\f0ee"; }

.fa-user-md:before {
  content: "\f0f0"; }

.fa-stethoscope:before {
  content: "\f0f1"; }

.fa-suitcase:before {
  content: "\f0f2"; }

.fa-bell-o:before {
  content: "\f0a2"; }

.fa-coffee:before {
  content: "\f0f4"; }

.fa-cutlery:before {
  content: "\f0f5"; }

.fa-file-text-o:before {
  content: "\f0f6"; }

.fa-building-o:before {
  content: "\f0f7"; }

.fa-hospital-o:before {
  content: "\f0f8"; }

.fa-ambulance:before {
  content: "\f0f9"; }

.fa-medkit:before {
  content: "\f0fa"; }

.fa-fighter-jet:before {
  content: "\f0fb"; }

.fa-beer:before {
  content: "\f0fc"; }

.fa-h-square:before {
  content: "\f0fd"; }

.fa-plus-square:before {
  content: "\f0fe"; }

.fa-angle-double-left:before {
  content: "\f100"; }

.fa-angle-double-right:before {
  content: "\f101"; }

.fa-angle-double-up:before {
  content: "\f102"; }

.fa-angle-double-down:before {
  content: "\f103"; }

.fa-angle-left:before {
  content: "\f104"; }

.fa-angle-right:before {
  content: "\f105"; }

.fa-angle-up:before {
  content: "\f106"; }

.fa-angle-down:before {
  content: "\f107"; }

.fa-desktop:before {
  content: "\f108"; }

.fa-laptop:before {
  content: "\f109"; }

.fa-tablet:before {
  content: "\f10a"; }

.fa-mobile-phone:before,
.fa-mobile:before {
  content: "\f10b"; }

.fa-circle-o:before {
  content: "\f10c"; }

.fa-quote-left:before {
  content: "\f10d"; }

.fa-quote-right:before {
  content: "\f10e"; }

.fa-spinner:before {
  content: "\f110"; }

.fa-circle:before {
  content: "\f111"; }

.fa-mail-reply:before,
.fa-reply:before {
  content: "\f112"; }

.fa-github-alt:before {
  content: "\f113"; }

.fa-folder-o:before {
  content: "\f114"; }

.fa-folder-open-o:before {
  content: "\f115"; }

.fa-smile-o:before {
  content: "\f118"; }

.fa-frown-o:before {
  content: "\f119"; }

.fa-meh-o:before {
  content: "\f11a"; }

.fa-gamepad:before {
  content: "\f11b"; }

.fa-keyboard-o:before {
  content: "\f11c"; }

.fa-flag-o:before {
  content: "\f11d"; }

.fa-flag-checkered:before {
  content: "\f11e"; }

.fa-terminal:before {
  content: "\f120"; }

.fa-code:before {
  content: "\f121"; }

.fa-mail-reply-all:before,
.fa-reply-all:before {
  content: "\f122"; }

.fa-star-half-empty:before,
.fa-star-half-full:before,
.fa-star-half-o:before {
  content: "\f123"; }

.fa-location-arrow:before {
  content: "\f124"; }

.fa-crop:before {
  content: "\f125"; }

.fa-code-fork:before {
  content: "\f126"; }

.fa-unlink:before,
.fa-chain-broken:before {
  content: "\f127"; }

.fa-question:before {
  content: "\f128"; }

.fa-info:before {
  content: "\f129"; }

.fa-exclamation:before {
  content: "\f12a"; }

.fa-superscript:before {
  content: "\f12b"; }

.fa-subscript:before {
  content: "\f12c"; }

.fa-eraser:before {
  content: "\f12d"; }

.fa-puzzle-piece:before {
  content: "\f12e"; }

.fa-microphone:before {
  content: "\f130"; }

.fa-microphone-slash:before {
  content: "\f131"; }

.fa-shield:before {
  content: "\f132"; }

.fa-calendar-o:before {
  content: "\f133"; }

.fa-fire-extinguisher:before {
  content: "\f134"; }

.fa-rocket:before {
  content: "\f135"; }

.fa-maxcdn:before {
  content: "\f136"; }

.fa-chevron-circle-left:before {
  content: "\f137"; }

.fa-chevron-circle-right:before {
  content: "\f138"; }

.fa-chevron-circle-up:before {
  content: "\f139"; }

.fa-chevron-circle-down:before {
  content: "\f13a"; }

.fa-html5:before {
  content: "\f13b"; }

.fa-css3:before {
  content: "\f13c"; }

.fa-anchor:before {
  content: "\f13d"; }

.fa-unlock-alt:before {
  content: "\f13e"; }

.fa-bullseye:before {
  content: "\f140"; }

.fa-ellipsis-h:before {
  content: "\f141"; }

.fa-ellipsis-v:before {
  content: "\f142"; }

.fa-rss-square:before {
  content: "\f143"; }

.fa-play-circle:before {
  content: "\f144"; }

.fa-ticket:before {
  content: "\f145"; }

.fa-minus-square:before {
  content: "\f146"; }

.fa-minus-square-o:before {
  content: "\f147"; }

.fa-level-up:before {
  content: "\f148"; }

.fa-level-down:before {
  content: "\f149"; }

.fa-check-square:before {
  content: "\f14a"; }

.fa-pencil-square:before {
  content: "\f14b"; }

.fa-external-link-square:before {
  content: "\f14c"; }

.fa-share-square:before {
  content: "\f14d"; }

.fa-compass:before {
  content: "\f14e"; }

.fa-toggle-down:before,
.fa-caret-square-o-down:before {
  content: "\f150"; }

.fa-toggle-up:before,
.fa-caret-square-o-up:before {
  content: "\f151"; }

.fa-toggle-right:before,
.fa-caret-square-o-right:before {
  content: "\f152"; }

.fa-euro:before,
.fa-eur:before {
  content: "\f153"; }

.fa-gbp:before {
  content: "\f154"; }

.fa-dollar:before,
.fa-usd:before {
  content: "\f155"; }

.fa-rupee:before,
.fa-inr:before {
  content: "\f156"; }

.fa-cny:before,
.fa-rmb:before,
.fa-yen:before,
.fa-jpy:before {
  content: "\f157"; }

.fa-ruble:before,
.fa-rouble:before,
.fa-rub:before {
  content: "\f158"; }

.fa-won:before,
.fa-krw:before {
  content: "\f159"; }

.fa-bitcoin:before,
.fa-btc:before {
  content: "\f15a"; }

.fa-file:before {
  content: "\f15b"; }

.fa-file-text:before {
  content: "\f15c"; }

.fa-sort-alpha-asc:before {
  content: "\f15d"; }

.fa-sort-alpha-desc:before {
  content: "\f15e"; }

.fa-sort-amount-asc:before {
  content: "\f160"; }

.fa-sort-amount-desc:before {
  content: "\f161"; }

.fa-sort-numeric-asc:before {
  content: "\f162"; }

.fa-sort-numeric-desc:before {
  content: "\f163"; }

.fa-thumbs-up:before {
  content: "\f164"; }

.fa-thumbs-down:before {
  content: "\f165"; }

.fa-youtube-square:before {
  content: "\f166"; }

.fa-youtube:before {
  content: "\f167"; }

.fa-xing:before {
  content: "\f168"; }

.fa-xing-square:before {
  content: "\f169"; }

.fa-youtube-play:before {
  content: "\f16a"; }

.fa-dropbox:before {
  content: "\f16b"; }

.fa-stack-overflow:before {
  content: "\f16c"; }

.fa-instagram:before {
  content: "\f16d"; }

.fa-flickr:before {
  content: "\f16e"; }

.fa-adn:before {
  content: "\f170"; }

.fa-bitbucket:before {
  content: "\f171"; }

.fa-bitbucket-square:before {
  content: "\f172"; }

.fa-tumblr:before {
  content: "\f173"; }

.fa-tumblr-square:before {
  content: "\f174"; }

.fa-long-arrow-down:before {
  content: "\f175"; }

.fa-long-arrow-up:before {
  content: "\f176"; }

.fa-long-arrow-left:before {
  content: "\f177"; }

.fa-long-arrow-right:before {
  content: "\f178"; }

.fa-apple:before {
  content: "\f179"; }

.fa-windows:before {
  content: "\f17a"; }

.fa-android:before {
  content: "\f17b"; }

.fa-linux:before {
  content: "\f17c"; }

.fa-dribbble:before {
  content: "\f17d"; }

.fa-skype:before {
  content: "\f17e"; }

.fa-foursquare:before {
  content: "\f180"; }

.fa-trello:before {
  content: "\f181"; }

.fa-female:before {
  content: "\f182"; }

.fa-male:before {
  content: "\f183"; }

.fa-gittip:before {
  content: "\f184"; }

.fa-sun-o:before {
  content: "\f185"; }

.fa-moon-o:before {
  content: "\f186"; }

.fa-archive:before {
  content: "\f187"; }

.fa-bug:before {
  content: "\f188"; }

.fa-vk:before {
  content: "\f189"; }

.fa-weibo:before {
  content: "\f18a"; }

.fa-renren:before {
  content: "\f18b"; }

.fa-pagelines:before {
  content: "\f18c"; }

.fa-stack-exchange:before {
  content: "\f18d"; }

.fa-arrow-circle-o-right:before {
  content: "\f18e"; }

.fa-arrow-circle-o-left:before {
  content: "\f190"; }

.fa-toggle-left:before,
.fa-caret-square-o-left:before {
  content: "\f191"; }

.fa-dot-circle-o:before {
  content: "\f192"; }

.fa-wheelchair:before {
  content: "\f193"; }

.fa-vimeo-square:before {
  content: "\f194"; }

.fa-turkish-lira:before,
.fa-try:before {
  content: "\f195"; }

.fa-plus-square-o:before {
  content: "\f196"; }

.fa-space-shuttle:before {
  content: "\f197"; }

.fa-slack:before {
  content: "\f198"; }

.fa-envelope-square:before {
  content: "\f199"; }

.fa-wordpress:before {
  content: "\f19a"; }

.fa-openid:before {
  content: "\f19b"; }

.fa-institution:before,
.fa-bank:before,
.fa-university:before {
  content: "\f19c"; }

.fa-mortar-board:before,
.fa-graduation-cap:before {
  content: "\f19d"; }

.fa-yahoo:before {
  content: "\f19e"; }

.fa-google:before {
  content: "\f1a0"; }

.fa-reddit:before {
  content: "\f1a1"; }

.fa-reddit-square:before {
  content: "\f1a2"; }

.fa-stumbleupon-circle:before {
  content: "\f1a3"; }

.fa-stumbleupon:before {
  content: "\f1a4"; }

.fa-delicious:before {
  content: "\f1a5"; }

.fa-digg:before {
  content: "\f1a6"; }

.fa-pied-piper:before {
  content: "\f1a7"; }

.fa-pied-piper-alt:before {
  content: "\f1a8"; }

.fa-drupal:before {
  content: "\f1a9"; }

.fa-joomla:before {
  content: "\f1aa"; }

.fa-language:before {
  content: "\f1ab"; }

.fa-fax:before {
  content: "\f1ac"; }

.fa-building:before {
  content: "\f1ad"; }

.fa-child:before {
  content: "\f1ae"; }

.fa-paw:before {
  content: "\f1b0"; }

.fa-spoon:before {
  content: "\f1b1"; }

.fa-cube:before {
  content: "\f1b2"; }

.fa-cubes:before {
  content: "\f1b3"; }

.fa-behance:before {
  content: "\f1b4"; }

.fa-behance-square:before {
  content: "\f1b5"; }

.fa-steam:before {
  content: "\f1b6"; }

.fa-steam-square:before {
  content: "\f1b7"; }

.fa-recycle:before {
  content: "\f1b8"; }

.fa-automobile:before,
.fa-car:before {
  content: "\f1b9"; }

.fa-cab:before,
.fa-taxi:before {
  content: "\f1ba"; }

.fa-tree:before {
  content: "\f1bb"; }

.fa-spotify:before {
  content: "\f1bc"; }

.fa-deviantart:before {
  content: "\f1bd"; }

.fa-soundcloud:before {
  content: "\f1be"; }

.fa-database:before {
  content: "\f1c0"; }

.fa-file-pdf-o:before {
  content: "\f1c1"; }

.fa-file-word-o:before {
  content: "\f1c2"; }

.fa-file-excel-o:before {
  content: "\f1c3"; }

.fa-file-powerpoint-o:before {
  content: "\f1c4"; }

.fa-file-photo-o:before,
.fa-file-picture-o:before,
.fa-file-image-o:before {
  content: "\f1c5"; }

.fa-file-zip-o:before,
.fa-file-archive-o:before {
  content: "\f1c6"; }

.fa-file-sound-o:before,
.fa-file-audio-o:before {
  content: "\f1c7"; }

.fa-file-movie-o:before,
.fa-file-video-o:before {
  content: "\f1c8"; }

.fa-file-code-o:before {
  content: "\f1c9"; }

.fa-vine:before {
  content: "\f1ca"; }

.fa-codepen:before {
  content: "\f1cb"; }

.fa-jsfiddle:before {
  content: "\f1cc"; }

.fa-life-bouy:before,
.fa-life-buoy:before,
.fa-life-saver:before,
.fa-support:before,
.fa-life-ring:before {
  content: "\f1cd"; }

.fa-circle-o-notch:before {
  content: "\f1ce"; }

.fa-ra:before,
.fa-rebel:before {
  content: "\f1d0"; }

.fa-ge:before,
.fa-empire:before {
  content: "\f1d1"; }

.fa-git-square:before {
  content: "\f1d2"; }

.fa-git:before {
  content: "\f1d3"; }

.fa-hacker-news:before {
  content: "\f1d4"; }

.fa-tencent-weibo:before {
  content: "\f1d5"; }

.fa-qq:before {
  content: "\f1d6"; }

.fa-wechat:before,
.fa-weixin:before {
  content: "\f1d7"; }

.fa-send:before,
.fa-paper-plane:before {
  content: "\f1d8"; }

.fa-send-o:before,
.fa-paper-plane-o:before {
  content: "\f1d9"; }

.fa-history:before {
  content: "\f1da"; }

.fa-circle-thin:before {
  content: "\f1db"; }

.fa-header:before {
  content: "\f1dc"; }

.fa-paragraph:before {
  content: "\f1dd"; }

.fa-sliders:before {
  content: "\f1de"; }

.fa-share-alt:before {
  content: "\f1e0"; }

.fa-share-alt-square:before {
  content: "\f1e1"; }

.fa-bomb:before {
  content: "\f1e2"; }

.fa-soccer-ball-o:before,
.fa-futbol-o:before {
  content: "\f1e3"; }

.fa-tty:before {
  content: "\f1e4"; }

.fa-binoculars:before {
  content: "\f1e5"; }

.fa-plug:before {
  content: "\f1e6"; }

.fa-slideshare:before {
  content: "\f1e7"; }

.fa-twitch:before {
  content: "\f1e8"; }

.fa-yelp:before {
  content: "\f1e9"; }

.fa-newspaper-o:before {
  content: "\f1ea"; }

.fa-wifi:before {
  content: "\f1eb"; }

.fa-calculator:before {
  content: "\f1ec"; }

.fa-paypal:before {
  content: "\f1ed"; }

.fa-google-wallet:before {
  content: "\f1ee"; }

.fa-cc-visa:before {
  content: "\f1f0"; }

.fa-cc-mastercard:before {
  content: "\f1f1"; }

.fa-cc-discover:before {
  content: "\f1f2"; }

.fa-cc-amex:before {
  content: "\f1f3"; }

.fa-cc-paypal:before {
  content: "\f1f4"; }

.fa-cc-stripe:before {
  content: "\f1f5"; }

.fa-bell-slash:before {
  content: "\f1f6"; }

.fa-bell-slash-o:before {
  content: "\f1f7"; }

.fa-trash:before {
  content: "\f1f8"; }

.fa-copyright:before {
  content: "\f1f9"; }

.fa-at:before {
  content: "\f1fa"; }

.fa-eyedropper:before {
  content: "\f1fb"; }

.fa-paint-brush:before {
  content: "\f1fc"; }

.fa-birthday-cake:before {
  content: "\f1fd"; }

.fa-area-chart:before {
  content: "\f1fe"; }

.fa-pie-chart:before {
  content: "\f200"; }

.fa-line-chart:before {
  content: "\f201"; }

.fa-lastfm:before {
  content: "\f202"; }

.fa-lastfm-square:before {
  content: "\f203"; }

.fa-toggle-off:before {
  content: "\f204"; }

.fa-toggle-on:before {
  content: "\f205"; }

.fa-bicycle:before {
  content: "\f206"; }

.fa-bus:before {
  content: "\f207"; }

.fa-ioxhost:before {
  content: "\f208"; }

.fa-angellist:before {
  content: "\f209"; }

.fa-cc:before {
  content: "\f20a"; }

.fa-shekel:before,
.fa-sheqel:before,
.fa-ils:before {
  content: "\f20b"; }

.fa-meanpath:before {
  content: "\f20c"; }

/*  Bootstrap styles ---------------------------------- */
/*! normalize.css v3.0.0 | MIT License | git.io/normalize */
html {
  font-family: sans-serif;
  -ms-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%;
  height: 100%; }

body {
  margin: 0; }

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
nav,
section,
summary {
  display: block; }

audio, canvas, progress, video {
  display: inline-block;
  vertical-align: baseline; }

audio:not([controls]) {
  display: none;
  height: 0; }

[hidden],
template {
  display: none; }

a {
  background: 0 0; }

a:active,
a:hover {
  outline: 0; }

abbr[title] {
  border-bottom: 1px dotted; }

b, strong {
  font-weight: 700; }

dfn {
  font-style: italic; }

h1 {
  font-size: 2em;
  margin: .67em 0; }

mark {
  background: #ff0;
  color: #000; }

small {
  font-size: 80%; }

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline; }

sup {
  top: -.5em; }

sub {
  bottom: -.25em; }

img {
  border: 0; }

svg:not(:root) {
  overflow: hidden; }

figure {
  margin: 1em 40px; }

hr {
  -moz-box-sizing: content-box;
  box-sizing: content-box;
  height: 0; }

pre {
  overflow: auto; }

code, kbd, pre, samp {
  font-family: monospace,monospace;
  font-size: 1em; }

button,
input,
optgroup,
select,
textarea {
  color: inherit;
  font: inherit;
  margin: 0; }

button {
  overflow: visible; }

button,
select {
  text-transform: none; }

button,
html input[type=button],
input[type=reset],
input[type=submit] {
  -webkit-appearance: button;
  cursor: pointer; }

button[disabled],
html input[disabled] {
  cursor: default; }

button::-moz-focus-inner,
input::-moz-focus-inner {
  border: 0;
  padding: 0; }

input {
  line-height: normal; }

input[type=checkbox],
input[type=radio] {
  box-sizing: border-box;
  padding: 0; }

input[type=number]::-webkit-inner-spin-button,
input[type=number]::-webkit-outer-spin-button {
  height: auto; }

input[type=search] {
  -webkit-appearance: textfield;
  -moz-box-sizing: content-box;
  -webkit-box-sizing: content-box;
  box-sizing: content-box; }

input[type=search]::-webkit-search-cancel-button,
input[type=search]::-webkit-search-decoration {
  -webkit-appearance: none; }

fieldset {
  border: 1px solid silver;
  margin: 0 2px;
  padding: .35em .625em .75em; }

legend {
  border: 0;
  padding: 0; }

textarea {
  overflow: auto; }

optgroup {
  font-weight: 700; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

td, th {
  padding: 0; }

/*!
 * Bootstrap v3.1.1 (http://getbootstrap.com)
 * Copyright 2011-2014 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 */
.btn-default,
.btn-primary,
.btn-success,
.btn-info,
.btn-warning,
.btn-danger {
  text-shadow: 0 -1px 0 rgba(0, 0, 0, 0.2);
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15), 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15), 0 1px 1px rgba(0, 0, 0, 0.075); }

.btn-default:active,
.btn-primary:active,
.btn-success:active,
.btn-info:active,
.btn-warning:active,
.btn-danger:active,
.btn-default.active,
.btn-primary.active,
.btn-success.active,
.btn-info.active,
.btn-warning.active,
.btn-danger.active {
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }

.btn:active,
.btn.active {
  background-image: none; }

.btn-default {
  text-shadow: 0 1px 0 #fff;
  background-image: -webkit-linear-gradient(top, #fff 0%, #e0e0e0 100%);
  background-image: linear-gradient(to bottom, #fff 0%, #e0e0e0 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffffffff', endColorstr='#ffe0e0e0', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-color: #dbdbdb;
  border-color: #ccc; }

.btn-default:hover,
.btn-default:focus {
  background-color: #e0e0e0;
  background-position: 0 -15px; }

.btn-default:active,
.btn-default.active {
  background-color: #e0e0e0;
  border-color: #dbdbdb; }

.btn-primary {
  background-image: -webkit-linear-gradient(top, #428bca 0%, #2d6ca2 100%);
  background-image: linear-gradient(to bottom, #428bca 0%, #2d6ca2 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff428bca', endColorstr='#ff2d6ca2', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-color: #2b669a; }

.btn-primary:hover,
.btn-primary:focus {
  background-color: #2d6ca2;
  background-position: 0 -15px; }

.btn-primary:active,
.btn-primary.active {
  background-color: #2d6ca2;
  border-color: #2b669a; }

.btn-success {
  background-image: -webkit-linear-gradient(top, #5cb85c 0%, #419641 100%);
  background-image: linear-gradient(to bottom, #5cb85c 0%, #419641 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5cb85c', endColorstr='#ff419641', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-color: #3e8f3e; }

.btn-success:hover,
.btn-success:focus {
  background-color: #419641;
  background-position: 0 -15px; }

.btn-success:active,
.btn-success.active {
  background-color: #419641;
  border-color: #3e8f3e; }

.btn-info {
  background-image: -webkit-linear-gradient(top, #5bc0de 0%, #2aabd2 100%);
  background-image: linear-gradient(to bottom, #5bc0de 0%, #2aabd2 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5bc0de', endColorstr='#ff2aabd2', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-color: #28a4c9; }

.btn-info:hover,
.btn-info:focus {
  background-color: #2aabd2;
  background-position: 0 -15px; }

.btn-info:active,
.btn-info.active {
  background-color: #2aabd2;
  border-color: #28a4c9; }

.btn-warning {
  background-image: -webkit-linear-gradient(top, #f0ad4e 0%, #eb9316 100%);
  background-image: linear-gradient(to bottom, #f0ad4e 0%, #eb9316 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fff0ad4e', endColorstr='#ffeb9316', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-color: #e38d13; }

.btn-warning:hover,
.btn-warning:focus {
  background-color: #eb9316;
  background-position: 0 -15px; }

.btn-warning:active,
.btn-warning.active {
  background-color: #eb9316;
  border-color: #e38d13; }

.btn-danger {
  background-image: -webkit-linear-gradient(top, #d9534f 0%, #c12e2a 100%);
  background-image: linear-gradient(to bottom, #d9534f 0%, #c12e2a 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffd9534f', endColorstr='#ffc12e2a', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-color: #b92c28; }

.btn-danger:hover,
.btn-danger:focus {
  background-color: #c12e2a;
  background-position: 0 -15px; }

.btn-danger:active,
.btn-danger.active {
  background-color: #c12e2a;
  border-color: #b92c28; }

.thumbnail,
.img-thumbnail {
  -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.075);
  box-shadow: 0 1px 2px rgba(0, 0, 0, 0.075); }

.dropdown-menu > li > a:hover,
.dropdown-menu > li > a:focus {
  background-color: #e8e8e8;
  background-image: -webkit-linear-gradient(top, #f5f5f5 0%, #e8e8e8 100%);
  background-image: linear-gradient(to bottom, #f5f5f5 0%, #e8e8e8 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fff5f5f5', endColorstr='#ffe8e8e8', GradientType=0);
  background-repeat: repeat-x; }

.dropdown-menu > .active > a,
.dropdown-menu > .active > a:hover,
.dropdown-menu > .active > a:focus {
  background-color: #357ebd;
  background-image: -webkit-linear-gradient(top, #428bca 0%, #357ebd 100%);
  background-image: linear-gradient(to bottom, #428bca 0%, #357ebd 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff428bca', endColorstr='#ff357ebd', GradientType=0);
  background-repeat: repeat-x; }

.navbar-default {
  background-image: -webkit-linear-gradient(top, #fff 0%, #f8f8f8 100%);
  background-image: linear-gradient(to bottom, #fff 0%, #f8f8f8 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffffffff', endColorstr='#fff8f8f8', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15), 0 1px 5px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.15), 0 1px 5px rgba(0, 0, 0, 0.075); }

.navbar-default .navbar-nav > .active > a {
  background-image: -webkit-linear-gradient(top, #ebebeb 0%, #f3f3f3 100%);
  background-image: linear-gradient(to bottom, #ebebeb 0%, #f3f3f3 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffebebeb', endColorstr='#fff3f3f3', GradientType=0);
  background-repeat: repeat-x;
  -webkit-box-shadow: inset 0 3px 9px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 3px 9px rgba(0, 0, 0, 0.075); }

.navbar-brand,
.navbar-nav > li > a {
  text-shadow: 0 1px 0 rgba(255, 255, 255, 0.25); }

.navbar-inverse {
  background-image: -webkit-linear-gradient(top, #3c3c3c 0%, #222 100%);
  background-image: linear-gradient(to bottom, #3c3c3c 0%, #222 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff3c3c3c', endColorstr='#ff222222', GradientType=0);
  filter: progid:DXImageTransform.Microsoft.gradient(enabled = false);
  background-repeat: repeat-x; }

.navbar-inverse .navbar-nav > .active > a {
  background-image: -webkit-linear-gradient(top, #222 0%, #282828 100%);
  background-image: linear-gradient(to bottom, #222 0%, #282828 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff222222', endColorstr='#ff282828', GradientType=0);
  background-repeat: repeat-x;
  -webkit-box-shadow: inset 0 3px 9px rgba(0, 0, 0, 0.25);
  box-shadow: inset 0 3px 9px rgba(0, 0, 0, 0.25); }

.navbar-inverse .navbar-brand,
.navbar-inverse .navbar-nav > li > a {
  text-shadow: 0 -1px 0 rgba(0, 0, 0, 0.25); }

.navbar-static-top,
.navbar-fixed-top,
.navbar-fixed-bottom {
  border-radius: 0; }

.alert {
  text-shadow: 0 1px 0 rgba(255, 255, 255, 0.2);
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.25), 0 1px 2px rgba(0, 0, 0, 0.05);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.25), 0 1px 2px rgba(0, 0, 0, 0.05); }

.alert-success {
  background-image: -webkit-linear-gradient(top, #dff0d8 0%, #c8e5bc 100%);
  background-image: linear-gradient(to bottom, #dff0d8 0%, #c8e5bc 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffdff0d8', endColorstr='#ffc8e5bc', GradientType=0);
  background-repeat: repeat-x;
  border-color: #b2dba1; }

.alert-info {
  background-image: -webkit-linear-gradient(top, #d9edf7 0%, #b9def0 100%);
  background-image: linear-gradient(to bottom, #d9edf7 0%, #b9def0 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffd9edf7', endColorstr='#ffb9def0', GradientType=0);
  background-repeat: repeat-x;
  border-color: #9acfea; }

.alert-warning {
  background-image: -webkit-linear-gradient(top, #fcf8e3 0%, #f8efc0 100%);
  background-image: linear-gradient(to bottom, #fcf8e3 0%, #f8efc0 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fffcf8e3', endColorstr='#fff8efc0', GradientType=0);
  background-repeat: repeat-x;
  border-color: #f5e79e; }

.alert-danger {
  background-image: -webkit-linear-gradient(top, #f2dede 0%, #e7c3c3 100%);
  background-image: linear-gradient(to bottom, #f2dede 0%, #e7c3c3 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fff2dede', endColorstr='#ffe7c3c3', GradientType=0);
  background-repeat: repeat-x;
  border-color: #dca7a7; }

.progress {
  background-image: -webkit-linear-gradient(top, #ebebeb 0%, #f5f5f5 100%);
  background-image: linear-gradient(to bottom, #ebebeb 0%, #f5f5f5 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffebebeb', endColorstr='#fff5f5f5', GradientType=0);
  background-repeat: repeat-x; }

.progress-bar {
  background-image: -webkit-linear-gradient(top, #428bca 0%, #3071a9 100%);
  background-image: linear-gradient(to bottom, #428bca 0%, #3071a9 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff428bca', endColorstr='#ff3071a9', GradientType=0);
  background-repeat: repeat-x; }

.progress-bar-success {
  background-image: -webkit-linear-gradient(top, #5cb85c 0%, #449d44 100%);
  background-image: linear-gradient(to bottom, #5cb85c 0%, #449d44 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5cb85c', endColorstr='#ff449d44', GradientType=0);
  background-repeat: repeat-x; }

.progress-bar-info {
  background-image: -webkit-linear-gradient(top, #5bc0de 0%, #31b0d5 100%);
  background-image: linear-gradient(to bottom, #5bc0de 0%, #31b0d5 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff5bc0de', endColorstr='#ff31b0d5', GradientType=0);
  background-repeat: repeat-x; }

.progress-bar-warning {
  background-image: -webkit-linear-gradient(top, #f0ad4e 0%, #ec971f 100%);
  background-image: linear-gradient(to bottom, #f0ad4e 0%, #ec971f 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fff0ad4e', endColorstr='#ffec971f', GradientType=0);
  background-repeat: repeat-x; }

.progress-bar-danger {
  background-image: -webkit-linear-gradient(top, #d9534f 0%, #c9302c 100%);
  background-image: linear-gradient(to bottom, #d9534f 0%, #c9302c 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffd9534f', endColorstr='#ffc9302c', GradientType=0);
  background-repeat: repeat-x; }

.list-group {
  border-radius: 4px;
  -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.075);
  box-shadow: 0 1px 2px rgba(0, 0, 0, 0.075); }

.list-group-item.active,
.list-group-item.active:hover,
.list-group-item.active:focus {
  text-shadow: 0 -1px 0 #3071a9;
  background-image: -webkit-linear-gradient(top, #428bca 0%, #3278b3 100%);
  background-image: linear-gradient(to bottom, #428bca 0%, #3278b3 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff428bca', endColorstr='#ff3278b3', GradientType=0);
  background-repeat: repeat-x;
  border-color: #3278b3; }

.panel {
  -webkit-box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05);
  box-shadow: 0 1px 2px rgba(0, 0, 0, 0.05); }

.panel-default > .panel-heading {
  background-image: -webkit-linear-gradient(top, #f5f5f5 0%, #e8e8e8 100%);
  background-image: linear-gradient(to bottom, #f5f5f5 0%, #e8e8e8 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fff5f5f5', endColorstr='#ffe8e8e8', GradientType=0);
  background-repeat: repeat-x; }

.panel-primary > .panel-heading {
  background-image: -webkit-linear-gradient(top, #428bca 0%, #357ebd 100%);
  background-image: linear-gradient(to bottom, #428bca 0%, #357ebd 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ff428bca', endColorstr='#ff357ebd', GradientType=0);
  background-repeat: repeat-x; }

.panel-success > .panel-heading {
  background-image: -webkit-linear-gradient(top, #dff0d8 0%, #d0e9c6 100%);
  background-image: linear-gradient(to bottom, #dff0d8 0%, #d0e9c6 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffdff0d8', endColorstr='#ffd0e9c6', GradientType=0);
  background-repeat: repeat-x; }

.panel-info > .panel-heading {
  background-image: -webkit-linear-gradient(top, #d9edf7 0%, #c4e3f3 100%);
  background-image: linear-gradient(to bottom, #d9edf7 0%, #c4e3f3 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffd9edf7', endColorstr='#ffc4e3f3', GradientType=0);
  background-repeat: repeat-x; }

.panel-warning > .panel-heading {
  background-image: -webkit-linear-gradient(top, #fcf8e3 0%, #faf2cc 100%);
  background-image: linear-gradient(to bottom, #fcf8e3 0%, #faf2cc 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fffcf8e3', endColorstr='#fffaf2cc', GradientType=0);
  background-repeat: repeat-x; }

.panel-danger > .panel-heading {
  background-image: -webkit-linear-gradient(top, #f2dede 0%, #ebcccc 100%);
  background-image: linear-gradient(to bottom, #f2dede 0%, #ebcccc 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#fff2dede', endColorstr='#ffebcccc', GradientType=0);
  background-repeat: repeat-x; }

.well {
  background-image: -webkit-linear-gradient(top, #e8e8e8 0%, #f5f5f5 100%);
  background-image: linear-gradient(to bottom, #e8e8e8 0%, #f5f5f5 100%);
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#ffe8e8e8', endColorstr='#fff5f5f5', GradientType=0);
  background-repeat: repeat-x;
  border-color: #dcdcdc;
  -webkit-box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.05), 0 1px 0 rgba(255, 255, 255, 0.1);
  box-shadow: inset 0 1px 3px rgba(0, 0, 0, 0.05), 0 1px 0 rgba(255, 255, 255, 0.1); }

/*# sourceMappingURL=bootstrap-theme.css.map */
/*!
 * Bootstrap v3.1.1 (http://getbootstrap.com)
 * Copyright 2011-2014 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 */
/*! normalize.css v3.0.0 | MIT License | git.io/normalize */
html {
  font-family: sans-serif;
  -ms-text-size-adjust: 100%;
  -webkit-text-size-adjust: 100%;
  height: 100%; }

body {
  margin: 0; }

article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
nav,
section,
summary {
  display: block; }

audio, canvas, progress, video {
  display: inline-block;
  vertical-align: baseline; }

audio:not([controls]) {
  display: none;
  height: 0; }

[hidden],
template {
  display: none; }

a {
  background: 0 0; }

a:active,
a:hover {
  outline: 0; }

abbr[title] {
  border-bottom: 1px dotted; }

b, strong {
  font-weight: 700; }

dfn {
  font-style: italic; }

h1 {
  font-size: 2em;
  margin: .67em 0; }

mark {
  background: #ff0;
  color: #000; }

small {
  font-size: 80%; }

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline; }

sup {
  top: -.5em; }

sub {
  bottom: -.25em; }

img {
  border: 0; }

svg:not(:root) {
  overflow: hidden; }

figure {
  margin: 1em 40px; }

hr {
  -moz-box-sizing: content-box;
  box-sizing: content-box;
  height: 0; }

pre {
  overflow: auto; }

code, kbd, pre, samp {
  font-family: monospace,monospace;
  font-size: 1em; }

button,
input,
optgroup,
select,
textarea {
  color: inherit;
  font: inherit;
  margin: 0; }

button {
  overflow: visible; }

button,
select {
  text-transform: none; }

button,
html input[type=button],
input[type=reset],
input[type=submit] {
  -webkit-appearance: button;
  cursor: pointer; }

button[disabled],
html input[disabled] {
  cursor: default; }

button::-moz-focus-inner,
input::-moz-focus-inner {
  border: 0;
  padding: 0; }

input {
  line-height: normal; }

input[type=checkbox],
input[type=radio] {
  box-sizing: border-box;
  padding: 0; }

input[type=number]::-webkit-inner-spin-button,
input[type=number]::-webkit-outer-spin-button {
  height: auto; }

input[type=search] {
  -webkit-appearance: textfield;
  -moz-box-sizing: content-box;
  -webkit-box-sizing: content-box;
  box-sizing: content-box; }

input[type=search]::-webkit-search-cancel-button,
input[type=search]::-webkit-search-decoration {
  -webkit-appearance: none; }

fieldset {
  border: 1px solid silver;
  margin: 0 2px;
  padding: .35em .625em .75em; }

legend {
  border: 0;
  padding: 0; }

textarea {
  overflow: auto; }

optgroup {
  font-weight: 700; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

td, th {
  padding: 0; }

@media print {
  * {
    text-shadow: none !important;
    color: #000 !important;
    background: transparent !important;
    box-shadow: none !important; }

  a, a:visited {
    text-decoration: underline; }

  a[href]:after {
    content: " (" attr(href) ")"; }

  abbr[title]:after {
    content: " (" attr(title) ")"; }

  a[href^="javascript:"]:after,
  a[href^="#"]:after {
    content: ""; }

  pre,
  blockquote {
    border: 1px solid #999;
    page-break-inside: avoid; }

  thead {
    display: table-header-group; }

  tr, img {
    page-break-inside: avoid; }

  img {
    max-width: 100% !important; }

  p, h2, h3 {
    orphans: 3;
    widows: 3; }

  h2, h3 {
    page-break-after: avoid; }

  select {
    background: #fff !important; }

  .navbar {
    display: none; }

  .table td,
  .table th {
    background-color: #fff !important; }

  .btn > .caret,
  .dropup > .btn > .caret {
    border-top-color: #000 !important; }

  .label {
    border: 1px solid #000; }

  .table {
    border-collapse: collapse !important; }

  .table-bordered th,
  .table-bordered td {
    border: 1px solid #ddd !important; } }
* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

:before,
:after {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

html {
  font-size: 62.5%;
  -webkit-tap-highlight-color: transparent; }

body {
  background-color: #fff;
  color: #333;
  font-family: "Helvetica Neue",Helvetica,Arial,sans-serif;
  font-size: 14px;
  line-height: 1.42857;
  overflow-x: hidden; }

input, button, select, textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit; }

a {
  color: #428bca;
  text-decoration: none; }

figure {
  margin: 0; }

img {
  vertical-align: middle; }

.img-responsive, .thumbnail > img, .thumbnail a > img, .carousel-inner > .item > img, .carousel-inner > .item > a > img {
  display: block;
  max-width: 100%;
  height: auto; }

.img-rounded {
  border-radius: 6px; }

.img-thumbnail {
  padding: 4px;
  line-height: 1.42857143;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  -webkit-transition: all .2s ease-in-out;
  transition: all .2s ease-in-out;
  display: inline-block;
  max-width: 100%;
  height: auto; }

.img-circle {
  border-radius: 50%; }

hr {
  margin-top: 20px;
  margin-bottom: 20px;
  border: 0;
  border-top: 1px solid #eee; }

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  margin: -1px;
  padding: 0;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  border: 0; }

h1, h2, h3, h4, h5, h6, .h1, .h2, .h3, .h4, .h5, .h6 {
  font-family: inherit;
  font-weight: 500;
  line-height: 1.1;
  color: inherit; }

h1 small, h2 small, h3 small, h4 small, h5 small, h6 small, .h1 small, .h2 small, .h3 small, .h4 small, .h5 small, .h6 small, h1 .small, h2 .small, h3 .small, h4 .small, h5 .small, h6 .small, .h1 .small, .h2 .small, .h3 .small, .h4 .small, .h5 .small, .h6 .small {
  font-weight: 400;
  line-height: 1;
  color: #999; }

h1, .h1, h2, .h2, h3, .h3 {
  margin-top: 20px;
  margin-bottom: 10px; }

h1 small, .h1 small, h2 small, .h2 small, h3 small, .h3 small, h1 .small, .h1 .small, h2 .small, .h2 .small, h3 .small, .h3 .small {
  font-size: 65%; }

h4, .h4, h5, .h5, h6, .h6 {
  margin-top: 10px;
  margin-bottom: 10px; }

h4 small, .h4 small, h5 small, .h5 small, h6 small, .h6 small, h4 .small, .h4 .small, h5 .small, .h5 .small, h6 .small, .h6 .small {
  font-size: 75%; }

h1, .h1 {
  font-size: 36px; }

h2, .h2 {
  font-size: 30px; }

h3, .h3 {
  font-size: 24px; }

h4, .h4 {
  font-size: 18px; }

h5, .h5 {
  font-size: 14px; }

h6, .h6 {
  font-size: 12px; }

p {
  margin: 0 0 10px; }

.lead {
  margin-bottom: 20px;
  font-size: 16px;
  font-weight: 200;
  line-height: 1.4; }

@media (min-width: 768px) {
  .lead {
    font-size: 21px; } }
small, .small {
  font-size: 85%; }

cite {
  font-style: normal; }

.text-left {
  text-align: left; }

.text-right {
  text-align: right; }

.text-center {
  text-align: center; }

.text-justify {
  text-align: justify; }

.text-muted {
  color: #999; }

.text-primary {
  color: #428bca; }

a.text-primary:hover {
  color: #3071a9; }

.text-success {
  color: #3c763d; }

a.text-success:hover {
  color: #2b542c; }

.text-info {
  color: #31708f; }

a.text-info:hover {
  color: #245269; }

.text-warning {
  color: #8a6d3b; }

a.text-warning:hover {
  color: #66512c; }

.text-danger {
  color: #a94442; }

a.text-danger:hover {
  color: #843534; }

.bg-primary {
  color: #fff;
  background-color: #428bca; }

a.bg-primary:hover {
  background-color: #3071a9; }

.bg-success {
  background-color: #dff0d8; }

a.bg-success:hover {
  background-color: #c1e2b3; }

.bg-info {
  background-color: #d9edf7; }

a.bg-info:hover {
  background-color: #afd9ee; }

.bg-warning {
  background-color: #fcf8e3; }

a.bg-warning:hover {
  background-color: #f7ecb5; }

.bg-danger {
  background-color: #f2dede; }

a.bg-danger:hover {
  background-color: #e4b9b9; }

.page-header {
  padding-bottom: 9px;
  margin: 40px 0 20px;
  border-bottom: 1px solid #eee; }

ul, ol {
  margin-top: 0;
  margin-bottom: 10px; }

ul ul, ol ul, ul ol, ol ol {
  margin-bottom: 0; }

.list-unstyled {
  padding-left: 0;
  list-style: none; }

.list-inline {
  padding-left: 0;
  list-style: none;
  margin-left: -5px; }

.list-inline > li {
  display: inline-block;
  padding-left: 5px;
  padding-right: 5px; }

dl {
  margin-top: 0;
  margin-bottom: 20px; }

dt, dd {
  line-height: 1.42857143; }

dt {
  font-weight: 700; }

dd {
  margin-left: 0; }

@media (min-width: 768px) {
  .dl-horizontal dt {
    float: left;
    width: 160px;
    clear: left;
    text-align: right;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap; }

  .dl-horizontal dd {
    margin-left: 180px; } }
abbr[title], abbr[data-original-title] {
  cursor: help;
  border-bottom: 1px dotted #999; }

.initialism {
  font-size: 90%;
  text-transform: uppercase; }

blockquote {
  padding: 10px 20px;
  margin: 0 0 20px;
  font-size: 17.5px;
  border-left: 5px solid #eee; }

blockquote p:last-child, blockquote ul:last-child, blockquote ol:last-child {
  margin-bottom: 0; }

blockquote footer, blockquote small, blockquote .small {
  display: block;
  font-size: 80%;
  line-height: 1.42857143;
  color: #999; }

blockquote footer:before, blockquote small:before, blockquote .small:before {
  content: '\2014 \00A0'; }

.blockquote-reverse, blockquote.pull-right {
  padding-right: 15px;
  padding-left: 0;
  border-right: 5px solid #eee;
  border-left: 0;
  text-align: right; }

.blockquote-reverse footer:before, blockquote.pull-right footer:before, .blockquote-reverse small:before, blockquote.pull-right small:before, .blockquote-reverse .small:before, blockquote.pull-right .small:before {
  content: ''; }

.blockquote-reverse footer:after, blockquote.pull-right footer:after, .blockquote-reverse small:after, blockquote.pull-right small:after, .blockquote-reverse .small:after, blockquote.pull-right .small:after {
  content: '\00A0 \2014'; }

blockquote:before, blockquote:after {
  content: ""; }

address {
  margin-bottom: 20px;
  font-style: normal;
  line-height: 1.42857143; }

code, kbd, pre, samp {
  font-family: Menlo,Monaco,Consolas,"Courier New",monospace; }

code {
  padding: 2px 4px;
  font-size: 90%;
  color: #c7254e;
  background-color: #f9f2f4;
  white-space: nowrap;
  border-radius: 4px; }

kbd {
  padding: 2px 4px;
  font-size: 90%;
  color: #fff;
  background-color: #333;
  border-radius: 3px;
  box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.25); }

pre {
  display: block;
  padding: 9.5px;
  margin: 0 0 10px;
  font-size: 13px;
  line-height: 1.42857143;
  word-break: break-all;
  word-wrap: break-word;
  color: #333;
  background-color: #f5f5f5;
  border: 1px solid #ccc;
  border-radius: 4px; }

pre code {
  padding: 0;
  font-size: inherit;
  color: inherit;
  white-space: pre-wrap;
  background-color: transparent;
  border-radius: 0; }

.pre-scrollable {
  max-height: 340px;
  overflow-y: scroll; }

/*  Increased container to width 100% for design*/
.container {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px;
  width: 100%; }

@media (min-width: 768px) {
  .container {
    width: 100%; } }
@media (min-width: 992px) {
  .container {
    width: 100%; } }
@media (min-width: 1200px) {
  .container {
    width: 100%; } }
.container-fluid {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px; }

.row {
  margin-left: -15px;
  margin-right: -15px; }

.col-xs-1, .col-sm-1, .col-md-1, .col-lg-1, .col-xs-2, .col-sm-2, .col-md-2, .col-lg-2, .col-xs-3, .col-sm-3, .col-md-3, .col-lg-3, .col-xs-4, .col-sm-4, .col-md-4, .col-lg-4, .col-xs-5, .col-sm-5, .col-md-5, .col-lg-5, .col-xs-6, .col-sm-6, .col-md-6, .col-lg-6, .col-xs-7, .col-sm-7, .col-md-7, .col-lg-7, .col-xs-8, .col-sm-8, .col-md-8, .col-lg-8, .col-xs-9, .col-sm-9, .col-md-9, .col-lg-9, .col-xs-10, .col-sm-10, .col-md-10, .col-lg-10, .col-xs-11, .col-sm-11, .col-md-11, .col-lg-11, .col-xs-12, .col-sm-12, .col-md-12, .col-lg-12 {
  position: relative;
  min-height: 1px;
  padding-left: 15px;
  padding-right: 15px; }

.col-xs-1, .col-xs-2, .col-xs-3, .col-xs-4, .col-xs-5, .col-xs-6, .col-xs-7, .col-xs-8, .col-xs-9, .col-xs-10, .col-xs-11, .col-xs-12 {
  float: left; }

.col-xs-12 {
  width: 100%; }

.col-xs-11 {
  width: 91.66666667%; }

.col-xs-10 {
  width: 83.33333333%; }

.col-xs-9 {
  width: 75%; }

.col-xs-8 {
  width: 66.66666667%; }

.col-xs-7 {
  width: 58.33333333%; }

.col-xs-6 {
  width: 50%; }

.col-xs-5 {
  width: 41.66666667%; }

.col-xs-4 {
  width: 33.33333333%; }

.col-xs-3 {
  width: 25%; }

.col-xs-2 {
  width: 16.66666667%; }

.col-xs-1 {
  width: 8.33333333%; }

.col-xs-pull-12 {
  right: 100%; }

.col-xs-pull-11 {
  right: 91.66666667%; }

.col-xs-pull-10 {
  right: 83.33333333%; }

.col-xs-pull-9 {
  right: 75%; }

.col-xs-pull-8 {
  right: 66.66666667%; }

.col-xs-pull-7 {
  right: 58.33333333%; }

.col-xs-pull-6 {
  right: 50%; }

.col-xs-pull-5 {
  right: 41.66666667%; }

.col-xs-pull-4 {
  right: 33.33333333%; }

.col-xs-pull-3 {
  right: 25%; }

.col-xs-pull-2 {
  right: 16.66666667%; }

.col-xs-pull-1 {
  right: 8.33333333%; }

.col-xs-pull-0 {
  right: 0; }

.col-xs-push-12 {
  left: 100%; }

.col-xs-push-11 {
  left: 91.66666667%; }

.col-xs-push-10 {
  left: 83.33333333%; }

.col-xs-push-9 {
  left: 75%; }

.col-xs-push-8 {
  left: 66.66666667%; }

.col-xs-push-7 {
  left: 58.33333333%; }

.col-xs-push-6 {
  left: 50%; }

.col-xs-push-5 {
  left: 41.66666667%; }

.col-xs-push-4 {
  left: 33.33333333%; }

.col-xs-push-3 {
  left: 25%; }

.col-xs-push-2 {
  left: 16.66666667%; }

.col-xs-push-1 {
  left: 8.33333333%; }

.col-xs-push-0 {
  left: 0; }

.col-xs-offset-12 {
  margin-left: 100%; }

.col-xs-offset-11 {
  margin-left: 91.66666667%; }

.col-xs-offset-10 {
  margin-left: 83.33333333%; }

.col-xs-offset-9 {
  margin-left: 75%; }

.col-xs-offset-8 {
  margin-left: 66.66666667%; }

.col-xs-offset-7 {
  margin-left: 58.33333333%; }

.col-xs-offset-6 {
  margin-left: 50%; }

.col-xs-offset-5 {
  margin-left: 41.66666667%; }

.col-xs-offset-4 {
  margin-left: 33.33333333%; }

.col-xs-offset-3 {
  margin-left: 25%; }

.col-xs-offset-2 {
  margin-left: 16.66666667%; }

.col-xs-offset-1 {
  margin-left: 8.33333333%; }

.col-xs-offset-0 {
  margin-left: 0; }

@media (min-width: 768px) {
  .col-sm-1, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-10, .col-sm-11, .col-sm-12 {
    float: left; }

  .col-sm-12 {
    width: 100%; }

  .col-sm-11 {
    width: 91.66666667%; }

  .col-sm-10 {
    width: 83.33333333%; }

  .col-sm-9 {
    width: 75%; }

  .col-sm-8 {
    width: 66.66666667%; }

  .col-sm-7 {
    width: 58.33333333%; }

  .col-sm-6 {
    width: 50%; }

  .col-sm-5 {
    width: 41.66666667%; }

  .col-sm-4 {
    width: 33.33333333%; }

  .col-sm-3 {
    width: 25%; }

  .col-sm-2 {
    width: 16.66666667%; }

  .col-sm-1 {
    width: 8.33333333%; }

  .col-sm-pull-12 {
    right: 100%; }

  .col-sm-pull-11 {
    right: 91.66666667%; }

  .col-sm-pull-10 {
    right: 83.33333333%; }

  .col-sm-pull-9 {
    right: 75%; }

  .col-sm-pull-8 {
    right: 66.66666667%; }

  .col-sm-pull-7 {
    right: 58.33333333%; }

  .col-sm-pull-6 {
    right: 50%; }

  .col-sm-pull-5 {
    right: 41.66666667%; }

  .col-sm-pull-4 {
    right: 33.33333333%; }

  .col-sm-pull-3 {
    right: 25%; }

  .col-sm-pull-2 {
    right: 16.66666667%; }

  .col-sm-pull-1 {
    right: 8.33333333%; }

  .col-sm-pull-0 {
    right: 0; }

  .col-sm-push-12 {
    left: 100%; }

  .col-sm-push-11 {
    left: 91.66666667%; }

  .col-sm-push-10 {
    left: 83.33333333%; }

  .col-sm-push-9 {
    left: 75%; }

  .col-sm-push-8 {
    left: 66.66666667%; }

  .col-sm-push-7 {
    left: 58.33333333%; }

  .col-sm-push-6 {
    left: 50%; }

  .col-sm-push-5 {
    left: 41.66666667%; }

  .col-sm-push-4 {
    left: 33.33333333%; }

  .col-sm-push-3 {
    left: 25%; }

  .col-sm-push-2 {
    left: 16.66666667%; }

  .col-sm-push-1 {
    left: 8.33333333%; }

  .col-sm-push-0 {
    left: 0; }

  .col-sm-offset-12 {
    margin-left: 100%; }

  .col-sm-offset-11 {
    margin-left: 91.66666667%; }

  .col-sm-offset-10 {
    margin-left: 83.33333333%; }

  .col-sm-offset-9 {
    margin-left: 75%; }

  .col-sm-offset-8 {
    margin-left: 66.66666667%; }

  .col-sm-offset-7 {
    margin-left: 58.33333333%; }

  .col-sm-offset-6 {
    margin-left: 50%; }

  .col-sm-offset-5 {
    margin-left: 41.66666667%; }

  .col-sm-offset-4 {
    margin-left: 33.33333333%; }

  .col-sm-offset-3 {
    margin-left: 25%; }

  .col-sm-offset-2 {
    margin-left: 16.66666667%; }

  .col-sm-offset-1 {
    margin-left: 8.33333333%; }

  .col-sm-offset-0 {
    margin-left: 0; } }
@media (min-width: 992px) {
  .col-md-1, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-10, .col-md-11, .col-md-12 {
    float: left; }

  .col-md-12 {
    width: 100%; }

  .col-md-11 {
    width: 91.66666667%; }

  .col-md-10 {
    width: 83.33333333%; }

  .col-md-9 {
    width: 75%; }

  .col-md-8 {
    width: 66.66666667%; }

  .col-md-7 {
    width: 58.33333333%; }

  .col-md-6 {
    width: 50%; }

  .col-md-5 {
    width: 41.66666667%; }

  .col-md-4 {
    width: 33.33333333%; }

  .col-md-3 {
    width: 25%; }

  .col-md-2 {
    width: 16.66666667%; }

  .col-md-1 {
    width: 8.33333333%; }

  .col-md-pull-12 {
    right: 100%; }

  .col-md-pull-11 {
    right: 91.66666667%; }

  .col-md-pull-10 {
    right: 83.33333333%; }

  .col-md-pull-9 {
    right: 75%; }

  .col-md-pull-8 {
    right: 66.66666667%; }

  .col-md-pull-7 {
    right: 58.33333333%; }

  .col-md-pull-6 {
    right: 50%; }

  .col-md-pull-5 {
    right: 41.66666667%; }

  .col-md-pull-4 {
    right: 33.33333333%; }

  .col-md-pull-3 {
    right: 25%; }

  .col-md-pull-2 {
    right: 16.66666667%; }

  .col-md-pull-1 {
    right: 8.33333333%; }

  .col-md-pull-0 {
    right: 0; }

  .col-md-push-12 {
    left: 100%; }

  .col-md-push-11 {
    left: 91.66666667%; }

  .col-md-push-10 {
    left: 83.33333333%; }

  .col-md-push-9 {
    left: 75%; }

  .col-md-push-8 {
    left: 66.66666667%; }

  .col-md-push-7 {
    left: 58.33333333%; }

  .col-md-push-6 {
    left: 50%; }

  .col-md-push-5 {
    left: 41.66666667%; }

  .col-md-push-4 {
    left: 33.33333333%; }

  .col-md-push-3 {
    left: 25%; }

  .col-md-push-2 {
    left: 16.66666667%; }

  .col-md-push-1 {
    left: 8.33333333%; }

  .col-md-push-0 {
    left: 0; }

  .col-md-offset-12 {
    margin-left: 100%; }

  .col-md-offset-11 {
    margin-left: 91.66666667%; }

  .col-md-offset-10 {
    margin-left: 83.33333333%; }

  .col-md-offset-9 {
    margin-left: 75%; }

  .col-md-offset-8 {
    margin-left: 66.66666667%; }

  .col-md-offset-7 {
    margin-left: 58.33333333%; }

  .col-md-offset-6 {
    margin-left: 50%; }

  .col-md-offset-5 {
    margin-left: 41.66666667%; }

  .col-md-offset-4 {
    margin-left: 33.33333333%; }

  .col-md-offset-3 {
    margin-left: 25%; }

  .col-md-offset-2 {
    margin-left: 16.66666667%; }

  .col-md-offset-1 {
    margin-left: 8.33333333%; }

  .col-md-offset-0 {
    margin-left: 0; } }
@media (min-width: 1200px) {
  .col-lg-1, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-10, .col-lg-11, .col-lg-12 {
    float: left; }

  .col-lg-12 {
    width: 100%; }

  .col-lg-11 {
    width: 91.66666667%; }

  .col-lg-10 {
    width: 83.33333333%; }

  .col-lg-9 {
    width: 75%; }

  .col-lg-8 {
    width: 66.66666667%; }

  .col-lg-7 {
    width: 58.33333333%; }

  .col-lg-6 {
    width: 50%; }

  .col-lg-5 {
    width: 41.66666667%; }

  .col-lg-4 {
    width: 33.33333333%; }

  .col-lg-3 {
    width: 25%; }

  .col-lg-2 {
    width: 16.66666667%; }

  .col-lg-1 {
    width: 8.33333333%; }

  .col-lg-pull-12 {
    right: 100%; }

  .col-lg-pull-11 {
    right: 91.66666667%; }

  .col-lg-pull-10 {
    right: 83.33333333%; }

  .col-lg-pull-9 {
    right: 75%; }

  .col-lg-pull-8 {
    right: 66.66666667%; }

  .col-lg-pull-7 {
    right: 58.33333333%; }

  .col-lg-pull-6 {
    right: 50%; }

  .col-lg-pull-5 {
    right: 41.66666667%; }

  .col-lg-pull-4 {
    right: 33.33333333%; }

  .col-lg-pull-3 {
    right: 25%; }

  .col-lg-pull-2 {
    right: 16.66666667%; }

  .col-lg-pull-1 {
    right: 8.33333333%; }

  .col-lg-pull-0 {
    right: 0; }

  .col-lg-push-12 {
    left: 100%; }

  .col-lg-push-11 {
    left: 91.66666667%; }

  .col-lg-push-10 {
    left: 83.33333333%; }

  .col-lg-push-9 {
    left: 75%; }

  .col-lg-push-8 {
    left: 66.66666667%; }

  .col-lg-push-7 {
    left: 58.33333333%; }

  .col-lg-push-6 {
    left: 50%; }

  .col-lg-push-5 {
    left: 41.66666667%; }

  .col-lg-push-4 {
    left: 33.33333333%; }

  .col-lg-push-3 {
    left: 25%; }

  .col-lg-push-2 {
    left: 16.66666667%; }

  .col-lg-push-1 {
    left: 8.33333333%; }

  .col-lg-push-0 {
    left: 0; }

  .col-lg-offset-12 {
    margin-left: 100%; }

  .col-lg-offset-11 {
    margin-left: 91.66666667%; }

  .col-lg-offset-10 {
    margin-left: 83.33333333%; }

  .col-lg-offset-9 {
    margin-left: 75%; }

  .col-lg-offset-8 {
    margin-left: 66.66666667%; }

  .col-lg-offset-7 {
    margin-left: 58.33333333%; }

  .col-lg-offset-6 {
    margin-left: 50%; }

  .col-lg-offset-5 {
    margin-left: 41.66666667%; }

  .col-lg-offset-4 {
    margin-left: 33.33333333%; }

  .col-lg-offset-3 {
    margin-left: 25%; }

  .col-lg-offset-2 {
    margin-left: 16.66666667%; }

  .col-lg-offset-1 {
    margin-left: 8.33333333%; }

  .col-lg-offset-0 {
    margin-left: 0; } }
table {
  max-width: 100%;
  background-color: transparent; }

th {
  text-align: left; }

.table {
  width: 100%;
  margin-bottom: 20px; }

.table > thead > tr > th, .table > tbody > tr > th, .table > tfoot > tr > th, .table > thead > tr > td, .table > tbody > tr > td, .table > tfoot > tr > td {
  padding: 8px;
  line-height: 1.42857143;
  vertical-align: top;
  border-top: 1px solid #ddd; }

.table > thead > tr > th {
  vertical-align: bottom;
  border-bottom: 2px solid #ddd; }

.table > caption + thead > tr:first-child > th, .table > colgroup + thead > tr:first-child > th, .table > thead:first-child > tr:first-child > th, .table > caption + thead > tr:first-child > td, .table > colgroup + thead > tr:first-child > td, .table > thead:first-child > tr:first-child > td {
  border-top: 0; }

.table > tbody + tbody {
  border-top: 2px solid #ddd; }

.table .table {
  background-color: #fff; }

.table-condensed > thead > tr > th, .table-condensed > tbody > tr > th, .table-condensed > tfoot > tr > th, .table-condensed > thead > tr > td, .table-condensed > tbody > tr > td, .table-condensed > tfoot > tr > td {
  padding: 5px; }

.table-bordered {
  border: 1px solid #ddd; }

.table-bordered > thead > tr > th, .table-bordered > tbody > tr > th, .table-bordered > tfoot > tr > th, .table-bordered > thead > tr > td, .table-bordered > tbody > tr > td, .table-bordered > tfoot > tr > td {
  border: 1px solid #ddd; }

.table-bordered > thead > tr > th, .table-bordered > thead > tr > td {
  border-bottom-width: 2px; }

.table-striped > tbody > tr:nth-child(odd) > td, .table-striped > tbody > tr:nth-child(odd) > th {
  background-color: #f9f9f9; }

.table-hover > tbody > tr:hover > td, .table-hover > tbody > tr:hover > th {
  background-color: #f5f5f5; }

table col[class*=col-] {
  position: static;
  float: none;
  display: table-column; }

table td[class*=col-], table th[class*=col-] {
  position: static;
  float: none;
  display: table-cell; }

.table > thead > tr > td.active, .table > tbody > tr > td.active, .table > tfoot > tr > td.active, .table > thead > tr > th.active, .table > tbody > tr > th.active, .table > tfoot > tr > th.active, .table > thead > tr.active > td, .table > tbody > tr.active > td, .table > tfoot > tr.active > td, .table > thead > tr.active > th, .table > tbody > tr.active > th, .table > tfoot > tr.active > th {
  background-color: #f5f5f5; }

.table-hover > tbody > tr > td.active:hover, .table-hover > tbody > tr > th.active:hover, .table-hover > tbody > tr.active:hover > td, .table-hover > tbody > tr.active:hover > th {
  background-color: #e8e8e8; }

.table > thead > tr > td.success, .table > tbody > tr > td.success, .table > tfoot > tr > td.success, .table > thead > tr > th.success, .table > tbody > tr > th.success, .table > tfoot > tr > th.success, .table > thead > tr.success > td, .table > tbody > tr.success > td, .table > tfoot > tr.success > td, .table > thead > tr.success > th, .table > tbody > tr.success > th, .table > tfoot > tr.success > th {
  background-color: #dff0d8; }

.table-hover > tbody > tr > td.success:hover, .table-hover > tbody > tr > th.success:hover, .table-hover > tbody > tr.success:hover > td, .table-hover > tbody > tr.success:hover > th {
  background-color: #d0e9c6; }

.table > thead > tr > td.info, .table > tbody > tr > td.info, .table > tfoot > tr > td.info, .table > thead > tr > th.info, .table > tbody > tr > th.info, .table > tfoot > tr > th.info, .table > thead > tr.info > td, .table > tbody > tr.info > td, .table > tfoot > tr.info > td, .table > thead > tr.info > th, .table > tbody > tr.info > th, .table > tfoot > tr.info > th {
  background-color: #d9edf7; }

.table-hover > tbody > tr > td.info:hover, .table-hover > tbody > tr > th.info:hover, .table-hover > tbody > tr.info:hover > td, .table-hover > tbody > tr.info:hover > th {
  background-color: #c4e3f3; }

.table > thead > tr > td.warning, .table > tbody > tr > td.warning, .table > tfoot > tr > td.warning, .table > thead > tr > th.warning, .table > tbody > tr > th.warning, .table > tfoot > tr > th.warning, .table > thead > tr.warning > td, .table > tbody > tr.warning > td, .table > tfoot > tr.warning > td, .table > thead > tr.warning > th, .table > tbody > tr.warning > th, .table > tfoot > tr.warning > th {
  background-color: #fcf8e3; }

.table-hover > tbody > tr > td.warning:hover, .table-hover > tbody > tr > th.warning:hover, .table-hover > tbody > tr.warning:hover > td, .table-hover > tbody > tr.warning:hover > th {
  background-color: #faf2cc; }

.table > thead > tr > td.danger, .table > tbody > tr > td.danger, .table > tfoot > tr > td.danger, .table > thead > tr > th.danger, .table > tbody > tr > th.danger, .table > tfoot > tr > th.danger, .table > thead > tr.danger > td, .table > tbody > tr.danger > td, .table > tfoot > tr.danger > td, .table > thead > tr.danger > th, .table > tbody > tr.danger > th, .table > tfoot > tr.danger > th {
  background-color: #f2dede; }

.table-hover > tbody > tr > td.danger:hover, .table-hover > tbody > tr > th.danger:hover, .table-hover > tbody > tr.danger:hover > td, .table-hover > tbody > tr.danger:hover > th {
  background-color: #ebcccc; }

@media (max-width: 767px) {
  .table-responsive {
    width: 100%;
    margin-bottom: 15px;
    overflow-y: hidden;
    overflow-x: scroll;
    -ms-overflow-style: -ms-autohiding-scrollbar;
    border: 1px solid #ddd;
    -webkit-overflow-scrolling: touch; }

  .table-responsive > .table {
    margin-bottom: 0; }

  .table-responsive > .table > thead > tr > th, .table-responsive > .table > tbody > tr > th, .table-responsive > .table > tfoot > tr > th, .table-responsive > .table > thead > tr > td, .table-responsive > .table > tbody > tr > td, .table-responsive > .table > tfoot > tr > td {
    white-space: nowrap; }

  .table-responsive > .table-bordered {
    border: 0; }

  .table-responsive > .table-bordered > thead > tr > th:first-child, .table-responsive > .table-bordered > tbody > tr > th:first-child, .table-responsive > .table-bordered > tfoot > tr > th:first-child, .table-responsive > .table-bordered > thead > tr > td:first-child, .table-responsive > .table-bordered > tbody > tr > td:first-child, .table-responsive > .table-bordered > tfoot > tr > td:first-child {
    border-left: 0; }

  .table-responsive > .table-bordered > thead > tr > th:last-child, .table-responsive > .table-bordered > tbody > tr > th:last-child, .table-responsive > .table-bordered > tfoot > tr > th:last-child, .table-responsive > .table-bordered > thead > tr > td:last-child, .table-responsive > .table-bordered > tbody > tr > td:last-child, .table-responsive > .table-bordered > tfoot > tr > td:last-child {
    border-right: 0; }

  .table-responsive > .table-bordered > tbody > tr:last-child > th, .table-responsive > .table-bordered > tfoot > tr:last-child > th, .table-responsive > .table-bordered > tbody > tr:last-child > td, .table-responsive > .table-bordered > tfoot > tr:last-child > td {
    border-bottom: 0; } }
fieldset {
  padding: 0;
  margin: 0;
  border: 0;
  min-width: 0; }

legend {
  display: block;
  width: 100%;
  padding: 0;
  margin-bottom: 20px;
  font-size: 21px;
  line-height: inherit;
  color: #333;
  border: 0;
  border-bottom: 1px solid #e5e5e5; }

label {
  display: inline-block;
  margin-bottom: 5px;
  font-weight: 700; }

input[type=search] {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

input[type=radio], input[type=checkbox] {
  margin: 4px 0 0;
  margin-top: 1px \9;
  line-height: normal; }

input[type=file] {
  display: block; }

input[type=range] {
  display: block;
  width: 100%; }

select[multiple], select[size] {
  height: auto; }

input[type=file]:focus, input[type=radio]:focus, input[type=checkbox]:focus {
  outline: thin dotted;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px; }

output {
  display: block;
  padding-top: 7px;
  font-size: 14px;
  line-height: 1.42857143;
  color: #555; }

.form-control {
  display: block;
  width: 100%;
  height: 34px;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.42857143;
  color: #555;
  background-color: #fff;
  background-image: none;
  border: 1px solid #ccc;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  -webkit-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
  transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s; }

.form-control:focus {
  border-color: #66afe9;
  outline: 0;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6); }

.form-control::-moz-placeholder {
  color: #999;
  opacity: 1; }

.form-control:-ms-input-placeholder {
  color: #999; }

.form-control::-webkit-input-placeholder {
  color: #999; }

.form-control[disabled], .form-control[readonly], fieldset[disabled] .form-control {
  cursor: not-allowed;
  background-color: #eee;
  opacity: 1; }

textarea.form-control {
  height: auto; }

input[type=search] {
  -webkit-appearance: none; }

input[type=date] {
  line-height: 34px; }

.form-group {
  margin-bottom: 15px; }

.radio, .checkbox {
  display: block;
  min-height: 20px;
  margin-top: 10px;
  margin-bottom: 10px;
  padding-left: 20px; }

.radio label, .checkbox label {
  display: inline;
  font-weight: 400;
  cursor: pointer; }

.radio input[type=radio], .radio-inline input[type=radio], .checkbox input[type=checkbox], .checkbox-inline input[type=checkbox] {
  float: left;
  margin-left: -20px; }

.radio + .radio, .checkbox + .checkbox {
  margin-top: -5px; }

.radio-inline, .checkbox-inline {
  display: inline-block;
  padding-left: 20px;
  margin-bottom: 0;
  vertical-align: middle;
  font-weight: 400;
  cursor: pointer; }

.radio-inline + .radio-inline, .checkbox-inline + .checkbox-inline {
  margin-top: 0;
  margin-left: 10px; }

input[type=radio][disabled], input[type=checkbox][disabled], .radio[disabled], .radio-inline[disabled], .checkbox[disabled], .checkbox-inline[disabled], fieldset[disabled] input[type=radio], fieldset[disabled] input[type=checkbox], fieldset[disabled] .radio, fieldset[disabled] .radio-inline, fieldset[disabled] .checkbox, fieldset[disabled] .checkbox-inline {
  cursor: not-allowed; }

.input-sm {
  height: 30px;
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

select.input-sm {
  height: 30px;
  line-height: 30px; }

textarea.input-sm, select[multiple].input-sm {
  height: auto; }

.input-lg {
  height: 46px;
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

select.input-lg {
  height: 46px;
  line-height: 46px; }

textarea.input-lg, select[multiple].input-lg {
  height: auto; }

.has-feedback {
  position: relative; }

.has-feedback .form-control {
  padding-right: 42.5px; }

.has-feedback .form-control-feedback {
  position: absolute;
  top: 25px;
  right: 0;
  display: block;
  width: 34px;
  height: 34px;
  line-height: 34px;
  text-align: center; }

.has-success .help-block, .has-success .control-label, .has-success .radio, .has-success .checkbox, .has-success .radio-inline, .has-success .checkbox-inline {
  color: #3c763d; }

.has-success .form-control {
  border-color: #3c763d;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }

.has-success .form-control:focus {
  border-color: #2b542c;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168; }

.has-success .input-group-addon {
  color: #3c763d;
  border-color: #3c763d;
  background-color: #dff0d8; }

.has-success .form-control-feedback {
  color: #3c763d; }

.has-warning .help-block, .has-warning .control-label, .has-warning .radio, .has-warning .checkbox, .has-warning .radio-inline, .has-warning .checkbox-inline {
  color: #8a6d3b; }

.has-warning .form-control {
  border-color: #8a6d3b;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }

.has-warning .form-control:focus {
  border-color: #66512c;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b; }

.has-warning .input-group-addon {
  color: #8a6d3b;
  border-color: #8a6d3b;
  background-color: #fcf8e3; }

.has-warning .form-control-feedback {
  color: #8a6d3b; }

.has-error .help-block, .has-error .control-label, .has-error .radio, .has-error .checkbox, .has-error .radio-inline, .has-error .checkbox-inline {
  color: #a94442; }

.has-error .form-control {
  border-color: #a94442;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }

.has-error .form-control:focus {
  border-color: #843534;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483; }

.has-error .input-group-addon {
  color: #a94442;
  border-color: #a94442;
  background-color: #f2dede; }

.has-error .form-control-feedback {
  color: #a94442; }

.form-control-static {
  margin-bottom: 0; }

.help-block {
  display: block;
  margin-top: 5px;
  margin-bottom: 10px;
  color: #737373; }

@media (min-width: 768px) {
  .form-inline .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle; }

  .form-inline .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle; }

  .form-inline .input-group > .form-control {
    width: 100%; }

  .form-inline .control-label {
    margin-bottom: 0;
    vertical-align: middle; }

  .form-inline .radio, .form-inline .checkbox {
    display: inline-block;
    margin-top: 0;
    margin-bottom: 0;
    padding-left: 0;
    vertical-align: middle; }

  .form-inline .radio input[type=radio], .form-inline .checkbox input[type=checkbox] {
    float: none;
    margin-left: 0; }

  .form-inline .has-feedback .form-control-feedback {
    top: 0; } }
.form-horizontal .control-label, .form-horizontal .radio, .form-horizontal .checkbox, .form-horizontal .radio-inline, .form-horizontal .checkbox-inline {
  margin-top: 0;
  margin-bottom: 0;
  padding-top: 7px; }

.form-horizontal .radio, .form-horizontal .checkbox {
  min-height: 27px; }

.form-horizontal .form-group {
  margin-left: -15px;
  margin-right: -15px; }

.form-horizontal .form-control-static {
  padding-top: 7px; }

@media (min-width: 768px) {
  .form-horizontal .control-label {
    text-align: right; } }
.form-horizontal .has-feedback .form-control-feedback {
  top: 0;
  right: 15px; }

.btn {
  display: inline-block;
  margin-bottom: 0;
  font-weight: 400;
  text-align: center;
  vertical-align: middle;
  cursor: pointer;
  background-image: none;
  border: 1px solid transparent;
  white-space: nowrap;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.42857143;
  border-radius: 4px;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none; }

.btn:focus, .btn:active:focus, .btn.active:focus {
  outline: thin dotted;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px; }

.btn:hover, .btn:focus {
  color: #333;
  text-decoration: none; }

.btn:active, .btn.active {
  outline: 0;
  background-image: none;
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }

.btn.disabled, .btn[disabled], fieldset[disabled] .btn {
  cursor: not-allowed;
  pointer-events: none;
  opacity: .65;
  filter: alpha(opacity=65);
  -webkit-box-shadow: none;
  box-shadow: none; }

.btn-default {
  color: #333;
  background-color: #fff;
  border-color: #ccc; }

.btn-default:hover, .btn-default:focus, .btn-default:active, .btn-default.active, .open .dropdown-toggle.btn-default {
  color: #333;
  background-color: #ebebeb;
  border-color: #adadad; }

.btn-default:active, .btn-default.active, .open .dropdown-toggle.btn-default {
  background-image: none; }

.btn-default.disabled, .btn-default[disabled], fieldset[disabled] .btn-default, .btn-default.disabled:hover, .btn-default[disabled]:hover, fieldset[disabled] .btn-default:hover, .btn-default.disabled:focus, .btn-default[disabled]:focus, fieldset[disabled] .btn-default:focus, .btn-default.disabled:active, .btn-default[disabled]:active, fieldset[disabled] .btn-default:active, .btn-default.disabled.active, .btn-default[disabled].active, fieldset[disabled] .btn-default.active {
  background-color: #fff;
  border-color: #ccc; }

.btn-default .badge {
  color: #fff;
  background-color: #333; }

.btn-primary:before {
  border: 4px solid #fff;
  border-radius: 10px;
  bottom: 0;
  content: "";
  display: block;
  left: 0;
  position: absolute;
  right: 0;
  top: 0; }

.btn-primary {
  border: 4px solid #1382c4;
  color: #fff;
  text-transform: uppercase;
  /* IE9 SVG, needs conditional override of 'filter' to 'none' */
  background: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/Pgo8c3ZnIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgdmlld0JveD0iMCAwIDEgMSIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+CiAgPGxpbmVhckdyYWRpZW50IGlkPSJncmFkLXVjZ2ctZ2VuZXJhdGVkIiBncmFkaWVudFVuaXRzPSJ1c2VyU3BhY2VPblVzZSIgeDE9IjAlIiB5MT0iMCUiIHgyPSIwJSIgeTI9IjEwMCUiPgogICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0iI2U3NDQ0YSIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjEwMCUiIHN0b3AtY29sb3I9IiM5NDE5MTMiIHN0b3Atb3BhY2l0eT0iMSIvPgogIDwvbGluZWFyR3JhZGllbnQ+CiAgPHJlY3QgeD0iMCIgeT0iMCIgd2lkdGg9IjEiIGhlaWdodD0iMSIgZmlsbD0idXJsKCNncmFkLXVjZ2ctZ2VuZXJhdGVkKSIgLz4KPC9zdmc+);
  background: -moz-linear-gradient(top, #e7444a 0%, #941913 100%);
  /* FF3.6+ */
  background: -webkit-gradient(linear, left top, left bottom, color-stop(0%, #e7444a), color-stop(100%, #941913));
  /* Chrome,Safari4+ */
  background: -webkit-linear-gradient(top, #e7444a 0%, #941913 100%);
  /* Chrome10+,Safari5.1+ */
  background: -o-linear-gradient(top, #e7444a 0%, #941913 100%);
  /* Opera 11.10+ */
  background: -ms-linear-gradient(top, #e7444a 0%, #941913 100%);
  /* IE10+ */
  background: linear-gradient(to bottom, #e7444a 0%, #941913 100%);
  /* W3C */
  filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#e7444a', endColorstr='#941913',GradientType=0 );
  /* IE6-8 */ }

.btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary {
  color: #fff;
  background-color: #3276b1;
  border-color: #285e8e; }

.btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary {
  background-image: none; }

.btn-primary.disabled, .btn-primary[disabled], fieldset[disabled] .btn-primary, .btn-primary.disabled:hover, .btn-primary[disabled]:hover, fieldset[disabled] .btn-primary:hover, .btn-primary.disabled:focus, .btn-primary[disabled]:focus, fieldset[disabled] .btn-primary:focus, .btn-primary.disabled:active, .btn-primary[disabled]:active, fieldset[disabled] .btn-primary:active, .btn-primary.disabled.active, .btn-primary[disabled].active, fieldset[disabled] .btn-primary.active {
  background-color: #428bca;
  border-color: #357ebd; }

.btn-primary .badge {
  color: #428bca;
  background-color: #fff; }

.btn-success {
  color: #fff;
  background-color: #5cb85c;
  border-color: #4cae4c; }

.btn-success:hover, .btn-success:focus, .btn-success:active, .btn-success.active, .open .dropdown-toggle.btn-success {
  color: #fff;
  background-color: #47a447;
  border-color: #398439; }

.btn-success:active, .btn-success.active, .open .dropdown-toggle.btn-success {
  background-image: none; }

.btn-success.disabled, .btn-success[disabled], fieldset[disabled] .btn-success, .btn-success.disabled:hover, .btn-success[disabled]:hover, fieldset[disabled] .btn-success:hover, .btn-success.disabled:focus, .btn-success[disabled]:focus, fieldset[disabled] .btn-success:focus, .btn-success.disabled:active, .btn-success[disabled]:active, fieldset[disabled] .btn-success:active, .btn-success.disabled.active, .btn-success[disabled].active, fieldset[disabled] .btn-success.active {
  background-color: #5cb85c;
  border-color: #4cae4c; }

.btn-success .badge {
  color: #5cb85c;
  background-color: #fff; }

.btn-info {
  color: #fff;
  background-color: #5bc0de;
  border-color: #46b8da; }

.btn-info:hover, .btn-info:focus, .btn-info:active, .btn-info.active, .open .dropdown-toggle.btn-info {
  color: #fff;
  background-color: #39b3d7;
  border-color: #269abc; }

.btn-info:active, .btn-info.active, .open .dropdown-toggle.btn-info {
  background-image: none; }

.btn-info.disabled, .btn-info[disabled], fieldset[disabled] .btn-info, .btn-info.disabled:hover, .btn-info[disabled]:hover, fieldset[disabled] .btn-info:hover, .btn-info.disabled:focus, .btn-info[disabled]:focus, fieldset[disabled] .btn-info:focus, .btn-info.disabled:active, .btn-info[disabled]:active, fieldset[disabled] .btn-info:active, .btn-info.disabled.active, .btn-info[disabled].active, fieldset[disabled] .btn-info.active {
  background-color: #5bc0de;
  border-color: #46b8da; }

.btn-info .badge {
  color: #5bc0de;
  background-color: #fff; }

.btn-warning {
  color: #fff;
  background-color: #f0ad4e;
  border-color: #eea236; }

.btn-warning:hover, .btn-warning:focus, .btn-warning:active, .btn-warning.active, .open .dropdown-toggle.btn-warning {
  color: #fff;
  background-color: #ed9c28;
  border-color: #d58512; }

.btn-warning:active, .btn-warning.active, .open .dropdown-toggle.btn-warning {
  background-image: none; }

.btn-warning.disabled, .btn-warning[disabled], fieldset[disabled] .btn-warning, .btn-warning.disabled:hover, .btn-warning[disabled]:hover, fieldset[disabled] .btn-warning:hover, .btn-warning.disabled:focus, .btn-warning[disabled]:focus, fieldset[disabled] .btn-warning:focus, .btn-warning.disabled:active, .btn-warning[disabled]:active, fieldset[disabled] .btn-warning:active, .btn-warning.disabled.active, .btn-warning[disabled].active, fieldset[disabled] .btn-warning.active {
  background-color: #f0ad4e;
  border-color: #eea236; }

.btn-warning .badge {
  color: #f0ad4e;
  background-color: #fff; }

.btn-danger {
  color: #fff;
  background-color: #d9534f;
  border-color: #d43f3a; }

.btn-danger:hover, .btn-danger:focus, .btn-danger:active, .btn-danger.active, .open .dropdown-toggle.btn-danger {
  color: #fff;
  background-color: #d2322d;
  border-color: #ac2925; }

.btn-danger:active, .btn-danger.active, .open .dropdown-toggle.btn-danger {
  background-image: none; }

.btn-danger.disabled, .btn-danger[disabled], fieldset[disabled] .btn-danger, .btn-danger.disabled:hover, .btn-danger[disabled]:hover, fieldset[disabled] .btn-danger:hover, .btn-danger.disabled:focus, .btn-danger[disabled]:focus, fieldset[disabled] .btn-danger:focus, .btn-danger.disabled:active, .btn-danger[disabled]:active, fieldset[disabled] .btn-danger:active, .btn-danger.disabled.active, .btn-danger[disabled].active, fieldset[disabled] .btn-danger.active {
  background-color: #d9534f;
  border-color: #d43f3a; }

.btn-danger .badge {
  color: #d9534f;
  background-color: #fff; }

.btn-link {
  color: #428bca;
  font-weight: 400;
  cursor: pointer;
  border-radius: 0; }

.btn-link, .btn-link:active, .btn-link[disabled], fieldset[disabled] .btn-link {
  background-color: transparent;
  -webkit-box-shadow: none;
  box-shadow: none; }

.btn-link, .btn-link:hover, .btn-link:focus, .btn-link:active {
  border-color: transparent; }

.btn-link:hover, .btn-link:focus {
  color: #2a6496;
  text-decoration: underline;
  background-color: transparent; }

.btn-link[disabled]:hover, fieldset[disabled] .btn-link:hover, .btn-link[disabled]:focus, fieldset[disabled] .btn-link:focus {
  color: #999;
  text-decoration: none; }

.btn-lg, .btn-group-lg > .btn {
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

.btn-sm, .btn-group-sm > .btn {
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

.btn-xs, .btn-group-xs > .btn {
  padding: 1px 5px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

.btn-block {
  display: block;
  width: 100%;
  padding-left: 0;
  padding-right: 0; }

.btn-block + .btn-block {
  margin-top: 5px; }

input[type=submit].btn-block, input[type=reset].btn-block, input[type=button].btn-block {
  width: 100%; }

.fade {
  opacity: 0;
  -webkit-transition: opacity .15s linear;
  transition: opacity .15s linear; }

.fade.in {
  opacity: 1; }

.collapse {
  display: none; }

.collapse.in {
  display: block; }

.collapsing {
  position: relative;
  height: 0;
  overflow: hidden;
  -webkit-transition: height .35s ease;
  transition: height .35s ease; }

@font-face {
  font-family: 'Glyphicons Halflings';
  src: url(../fonts/glyphicons-halflings-regular.eot);
  src: url(../fonts/glyphicons-halflings-regular.eot?#iefix) format("embedded-opentype"), url(../fonts/glyphicons-halflings-regular.woff) format("woff"), url(../fonts/glyphicons-halflings-regular.ttf) format("truetype"), url(../fonts/glyphicons-halflings-regular.svg#glyphicons_halflingsregular) format("svg"); }
.glyphicon {
  position: relative;
  top: 1px;
  display: inline-block;
  font-family: 'Glyphicons Halflings';
  font-style: normal;
  font-weight: 400;
  line-height: 1;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale; }

.glyphicon-asterisk:before {
  content: "\2a"; }

.glyphicon-plus:before {
  content: "\2b"; }

.glyphicon-euro:before {
  content: "\20ac"; }

.glyphicon-minus:before {
  content: "\2212"; }

.glyphicon-cloud:before {
  content: "\2601"; }

.glyphicon-envelope:before {
  content: "\2709"; }

.glyphicon-pencil:before {
  content: "\270f"; }

.glyphicon-glass:before {
  content: "\e001"; }

.glyphicon-music:before {
  content: "\e002"; }

.glyphicon-search:before {
  content: "\e003"; }

.glyphicon-heart:before {
  content: "\e005"; }

.glyphicon-star:before {
  content: "\e006"; }

.glyphicon-star-empty:before {
  content: "\e007"; }

.glyphicon-user:before {
  content: "\e008"; }

.glyphicon-film:before {
  content: "\e009"; }

.glyphicon-th-large:before {
  content: "\e010"; }

.glyphicon-th:before {
  content: "\e011"; }

.glyphicon-th-list:before {
  content: "\e012"; }

.glyphicon-ok:before {
  content: "\e013"; }

.glyphicon-remove:before {
  content: "\e014"; }

.glyphicon-zoom-in:before {
  content: "\e015"; }

.glyphicon-zoom-out:before {
  content: "\e016"; }

.glyphicon-off:before {
  content: "\e017"; }

.glyphicon-signal:before {
  content: "\e018"; }

.glyphicon-cog:before {
  content: "\e019"; }

.glyphicon-trash:before {
  content: "\e020"; }

.glyphicon-home:before {
  content: "\e021"; }

.glyphicon-file:before {
  content: "\e022"; }

.glyphicon-time:before {
  content: "\e023"; }

.glyphicon-road:before {
  content: "\e024"; }

.glyphicon-download-alt:before {
  content: "\e025"; }

.glyphicon-download:before {
  content: "\e026"; }

.glyphicon-upload:before {
  content: "\e027"; }

.glyphicon-inbox:before {
  content: "\e028"; }

.glyphicon-play-circle:before {
  content: "\e029"; }

.glyphicon-repeat:before {
  content: "\e030"; }

.glyphicon-refresh:before {
  content: "\e031"; }

.glyphicon-list-alt:before {
  content: "\e032"; }

.glyphicon-lock:before {
  content: "\e033"; }

.glyphicon-flag:before {
  content: "\e034"; }

.glyphicon-headphones:before {
  content: "\e035"; }

.glyphicon-volume-off:before {
  content: "\e036"; }

.glyphicon-volume-down:before {
  content: "\e037"; }

.glyphicon-volume-up:before {
  content: "\e038"; }

.glyphicon-qrcode:before {
  content: "\e039"; }

.glyphicon-barcode:before {
  content: "\e040"; }

.glyphicon-tag:before {
  content: "\e041"; }

.glyphicon-tags:before {
  content: "\e042"; }

.glyphicon-book:before {
  content: "\e043"; }

.glyphicon-bookmark:before {
  content: "\e044"; }

.glyphicon-print:before {
  content: "\e045"; }

.glyphicon-camera:before {
  content: "\e046"; }

.glyphicon-font:before {
  content: "\e047"; }

.glyphicon-bold:before {
  content: "\e048"; }

.glyphicon-italic:before {
  content: "\e049"; }

.glyphicon-text-height:before {
  content: "\e050"; }

.glyphicon-text-width:before {
  content: "\e051"; }

.glyphicon-align-left:before {
  content: "\e052"; }

.glyphicon-align-center:before {
  content: "\e053"; }

.glyphicon-align-right:before {
  content: "\e054"; }

.glyphicon-align-justify:before {
  content: "\e055"; }

.glyphicon-list:before {
  content: "\e056"; }

.glyphicon-indent-left:before {
  content: "\e057"; }

.glyphicon-indent-right:before {
  content: "\e058"; }

.glyphicon-facetime-video:before {
  content: "\e059"; }

.glyphicon-picture:before {
  content: "\e060"; }

.glyphicon-map-marker:before {
  content: "\e062"; }

.glyphicon-adjust:before {
  content: "\e063"; }

.glyphicon-tint:before {
  content: "\e064"; }

.glyphicon-edit:before {
  content: "\e065"; }

.glyphicon-share:before {
  content: "\e066"; }

.glyphicon-check:before {
  content: "\e067"; }

.glyphicon-move:before {
  content: "\e068"; }

.glyphicon-step-backward:before {
  content: "\e069"; }

.glyphicon-fast-backward:before {
  content: "\e070"; }

.glyphicon-backward:before {
  content: "\e071"; }

.glyphicon-play:before {
  content: "\e072"; }

.glyphicon-pause:before {
  content: "\e073"; }

.glyphicon-stop:before {
  content: "\e074"; }

.glyphicon-forward:before {
  content: "\e075"; }

.glyphicon-fast-forward:before {
  content: "\e076"; }

.glyphicon-step-forward:before {
  content: "\e077"; }

.glyphicon-eject:before {
  content: "\e078"; }

.glyphicon-chevron-left:before {
  content: "\e079"; }

.glyphicon-chevron-right:before {
  content: "\e080"; }

.glyphicon-plus-sign:before {
  content: "\e081"; }

.glyphicon-minus-sign:before {
  content: "\e082"; }

.glyphicon-remove-sign:before {
  content: "\e083"; }

.glyphicon-ok-sign:before {
  content: "\e084"; }

.glyphicon-question-sign:before {
  content: "\e085"; }

.glyphicon-info-sign:before {
  content: "\e086"; }

.glyphicon-screenshot:before {
  content: "\e087"; }

.glyphicon-remove-circle:before {
  content: "\e088"; }

.glyphicon-ok-circle:before {
  content: "\e089"; }

.glyphicon-ban-circle:before {
  content: "\e090"; }

.glyphicon-arrow-left:before {
  content: "\e091"; }

.glyphicon-arrow-right:before {
  content: "\e092"; }

/*  arrow right but after the element */
.glyphicon-arrow-after:after {
  content: "\e092"; }

.glyphicon-arrow-up:before {
  content: "\e093"; }

.glyphicon-arrow-down:before {
  content: "\e094"; }

.glyphicon-share-alt:before {
  content: "\e095"; }

.glyphicon-resize-full:before {
  content: "\e096"; }

.glyphicon-resize-small:before {
  content: "\e097"; }

.glyphicon-exclamation-sign:before {
  content: "\e101"; }

.glyphicon-gift:before {
  content: "\e102"; }

.glyphicon-leaf:before {
  content: "\e103"; }

.glyphicon-fire:before {
  content: "\e104"; }

.glyphicon-eye-open:before {
  content: "\e105"; }

.glyphicon-eye-close:before {
  content: "\e106"; }

.glyphicon-warning-sign:before {
  content: "\e107"; }

.glyphicon-plane:before {
  content: "\e108"; }

.glyphicon-calendar:before {
  content: "\e109"; }

.glyphicon-random:before {
  content: "\e110"; }

.glyphicon-comment:before {
  content: "\e111"; }

.glyphicon-magnet:before {
  content: "\e112"; }

.glyphicon-chevron-up:before {
  content: "\e113"; }

.glyphicon-chevron-down:before {
  content: "\e114"; }

.glyphicon-retweet:before {
  content: "\e115"; }

.glyphicon-shopping-cart:before {
  content: "\e116"; }

.glyphicon-folder-close:before {
  content: "\e117"; }

.glyphicon-folder-open:before {
  content: "\e118"; }

.glyphicon-resize-vertical:before {
  content: "\e119"; }

.glyphicon-resize-horizontal:before {
  content: "\e120"; }

.glyphicon-hdd:before {
  content: "\e121"; }

.glyphicon-bullhorn:before {
  content: "\e122"; }

.glyphicon-bell:before {
  content: "\e123"; }

.glyphicon-certificate:before {
  content: "\e124"; }

.glyphicon-thumbs-up:before {
  content: "\e125"; }

.glyphicon-thumbs-down:before {
  content: "\e126"; }

.glyphicon-hand-right:before {
  content: "\e127"; }

.glyphicon-hand-left:before {
  content: "\e128"; }

.glyphicon-hand-up:before {
  content: "\e129"; }

.glyphicon-hand-down:before {
  content: "\e130"; }

.glyphicon-circle-arrow-right:before {
  content: "\e131"; }

.glyphicon-circle-arrow-left:before {
  content: "\e132"; }

.glyphicon-circle-arrow-up:before {
  content: "\e133"; }

.glyphicon-circle-arrow-down:before {
  content: "\e134"; }

.glyphicon-globe:before {
  content: "\e135"; }

.glyphicon-wrench:before {
  content: "\e136"; }

.glyphicon-tasks:before {
  content: "\e137"; }

.glyphicon-filter:before {
  content: "\e138"; }

.glyphicon-briefcase:before {
  content: "\e139"; }

.glyphicon-fullscreen:before {
  content: "\e140"; }

.glyphicon-dashboard:before {
  content: "\e141"; }

.glyphicon-paperclip:before {
  content: "\e142"; }

.glyphicon-heart-empty:before {
  content: "\e143"; }

.glyphicon-link:before {
  content: "\e144"; }

.glyphicon-phone:before {
  content: "\e145"; }

.glyphicon-pushpin:before {
  content: "\e146"; }

.glyphicon-usd:before {
  content: "\e148"; }

.glyphicon-gbp:before {
  content: "\e149"; }

.glyphicon-sort:before {
  content: "\e150"; }

.glyphicon-sort-by-alphabet:before {
  content: "\e151"; }

.glyphicon-sort-by-alphabet-alt:before {
  content: "\e152"; }

.glyphicon-sort-by-order:before {
  content: "\e153"; }

.glyphicon-sort-by-order-alt:before {
  content: "\e154"; }

.glyphicon-sort-by-attributes:before {
  content: "\e155"; }

.glyphicon-sort-by-attributes-alt:before {
  content: "\e156"; }

.glyphicon-unchecked:before {
  content: "\e157"; }

.glyphicon-expand:before {
  content: "\e158"; }

.glyphicon-collapse-down:before {
  content: "\e159"; }

.glyphicon-collapse-up:before {
  content: "\e160"; }

.glyphicon-log-in:before {
  content: "\e161"; }

.glyphicon-flash:before {
  content: "\e162"; }

.glyphicon-log-out:before {
  content: "\e163"; }

.glyphicon-new-window:before {
  content: "\e164"; }

.glyphicon-record:before {
  content: "\e165"; }

.glyphicon-save:before {
  content: "\e166"; }

.glyphicon-open:before {
  content: "\e167"; }

.glyphicon-saved:before {
  content: "\e168"; }

.glyphicon-import:before {
  content: "\e169"; }

.glyphicon-export:before {
  content: "\e170"; }

.glyphicon-send:before {
  content: "\e171"; }

.glyphicon-floppy-disk:before {
  content: "\e172"; }

.glyphicon-floppy-saved:before {
  content: "\e173"; }

.glyphicon-floppy-remove:before {
  content: "\e174"; }

.glyphicon-floppy-save:before {
  content: "\e175"; }

.glyphicon-floppy-open:before {
  content: "\e176"; }

.glyphicon-credit-card:before {
  content: "\e177"; }

.glyphicon-transfer:before {
  content: "\e178"; }

.glyphicon-cutlery:before {
  content: "\e179"; }

.glyphicon-header:before {
  content: "\e180"; }

.glyphicon-compressed:before {
  content: "\e181"; }

.glyphicon-earphone:before {
  content: "\e182"; }

.glyphicon-phone-alt:before {
  content: "\e183"; }

.glyphicon-tower:before {
  content: "\e184"; }

.glyphicon-stats:before {
  content: "\e185"; }

.glyphicon-sd-video:before {
  content: "\e186"; }

.glyphicon-hd-video:before {
  content: "\e187"; }

.glyphicon-subtitles:before {
  content: "\e188"; }

.glyphicon-sound-stereo:before {
  content: "\e189"; }

.glyphicon-sound-dolby:before {
  content: "\e190"; }

.glyphicon-sound-5-1:before {
  content: "\e191"; }

.glyphicon-sound-6-1:before {
  content: "\e192"; }

.glyphicon-sound-7-1:before {
  content: "\e193"; }

.glyphicon-copyright-mark:before {
  content: "\e194"; }

.glyphicon-registration-mark:before {
  content: "\e195"; }

.glyphicon-cloud-download:before {
  content: "\e197"; }

.glyphicon-cloud-upload:before {
  content: "\e198"; }

.glyphicon-tree-conifer:before {
  content: "\e199"; }

.glyphicon-tree-deciduous:before {
  content: "\e200"; }

.caret {
  display: inline-block;
  width: 0;
  height: 0;
  margin-left: 2px;
  vertical-align: middle;
  border-top: 4px solid;
  border-right: 4px solid transparent;
  border-left: 4px solid transparent; }

.dropdown {
  position: relative; }

.dropdown-toggle:focus {
  outline: 0; }

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 1000;
  display: none;
  float: left;
  min-width: 160px;
  padding: 5px 0;
  margin: 2px 0 0;
  list-style: none;
  font-size: 14px;
  background-color: #fff;
  border: 1px solid #ccc;
  border: 1px solid rgba(0, 0, 0, 0.15);
  border-radius: 4px;
  -webkit-box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  background-clip: padding-box; }

.dropdown-menu.pull-right {
  right: 0;
  left: auto; }

.dropdown-menu .divider {
  height: 1px;
  margin: 9px 0;
  overflow: hidden;
  background-color: #e5e5e5; }

.dropdown-menu > li > a {
  display: block;
  padding: 3px 20px;
  clear: both;
  font-weight: 400;
  line-height: 1.42857143;
  color: #333;
  white-space: nowrap; }

.dropdown-menu > li > a:hover, .dropdown-menu > li > a:focus {
  text-decoration: none;
  color: #262626;
  background-color: #f5f5f5; }

.dropdown-menu > .active > a, .dropdown-menu > .active > a:hover, .dropdown-menu > .active > a:focus {
  color: #fff;
  text-decoration: none;
  outline: 0;
  background-color: #428bca; }

.dropdown-menu > .disabled > a, .dropdown-menu > .disabled > a:hover, .dropdown-menu > .disabled > a:focus {
  color: #999; }

.dropdown-menu > .disabled > a:hover, .dropdown-menu > .disabled > a:focus {
  text-decoration: none;
  background-color: transparent;
  background-image: none;
  filter: progid:DXImageTransform.Microsoft.gradient(enabled=false);
  cursor: not-allowed; }

.open > .dropdown-menu {
  display: block; }

.open > a {
  outline: 0; }

.dropdown-menu-right {
  left: auto;
  right: 0; }

.dropdown-menu-left {
  left: 0;
  right: auto; }

.dropdown-header {
  display: block;
  padding: 3px 20px;
  font-size: 12px;
  line-height: 1.42857143;
  color: #999; }

.dropdown-backdrop {
  position: fixed;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
  z-index: 990; }

.pull-right > .dropdown-menu {
  right: 0;
  left: auto; }

.dropup .caret, .navbar-fixed-bottom .dropdown .caret {
  border-top: 0;
  border-bottom: 4px solid;
  content: ""; }

.dropup .dropdown-menu, .navbar-fixed-bottom .dropdown .dropdown-menu {
  top: auto;
  bottom: 100%;
  margin-bottom: 1px; }

@media (min-width: 768px) {
  .navbar-right .dropdown-menu {
    left: auto;
    right: 0; }

  .navbar-right .dropdown-menu-left {
    left: 0;
    right: auto; } }
.btn-group, .btn-group-vertical {
  position: relative;
  display: inline-block;
  vertical-align: middle; }

.btn-group > .btn, .btn-group-vertical > .btn {
  position: relative;
  float: left; }

.btn-group > .btn:hover, .btn-group-vertical > .btn:hover, .btn-group > .btn:focus, .btn-group-vertical > .btn:focus, .btn-group > .btn:active, .btn-group-vertical > .btn:active, .btn-group > .btn.active, .btn-group-vertical > .btn.active {
  z-index: 2; }

.btn-group > .btn:focus, .btn-group-vertical > .btn:focus {
  outline: 0; }

.btn-group .btn + .btn, .btn-group .btn + .btn-group, .btn-group .btn-group + .btn, .btn-group .btn-group + .btn-group {
  margin-left: -1px; }

.btn-toolbar {
  margin-left: -5px; }

.btn-toolbar .btn-group, .btn-toolbar .input-group {
  float: left; }

.btn-toolbar > .btn, .btn-toolbar > .btn-group, .btn-toolbar > .input-group {
  margin-left: 5px; }

.btn-group > .btn:not(:first-child):not(:last-child):not(.dropdown-toggle) {
  border-radius: 0; }

.btn-group > .btn:first-child {
  margin-left: 0; }

.btn-group > .btn:first-child:not(:last-child):not(.dropdown-toggle) {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.btn-group > .btn:last-child:not(:first-child), .btn-group > .dropdown-toggle:not(:first-child) {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.btn-group > .btn-group {
  float: left; }

.btn-group > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0; }

.btn-group > .btn-group:first-child > .btn:last-child, .btn-group > .btn-group:first-child > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.btn-group > .btn-group:last-child > .btn:first-child {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.btn-group .dropdown-toggle:active, .btn-group.open .dropdown-toggle {
  outline: 0; }

.btn-group > .btn + .dropdown-toggle {
  padding-left: 8px;
  padding-right: 8px; }

.btn-group > .btn-lg + .dropdown-toggle {
  padding-left: 12px;
  padding-right: 12px; }

.btn-group.open .dropdown-toggle {
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }

.btn-group.open .dropdown-toggle.btn-link {
  -webkit-box-shadow: none;
  box-shadow: none; }

.btn .caret {
  margin-left: 0; }

.btn-lg .caret {
  border-width: 5px 5px 0;
  border-bottom-width: 0; }

.dropup .btn-lg .caret {
  border-width: 0 5px 5px; }

.btn-group-vertical > .btn, .btn-group-vertical > .btn-group, .btn-group-vertical > .btn-group > .btn {
  display: block;
  float: none;
  width: 100%;
  max-width: 100%; }

.btn-group-vertical > .btn-group > .btn {
  float: none; }

.btn-group-vertical > .btn + .btn, .btn-group-vertical > .btn + .btn-group, .btn-group-vertical > .btn-group + .btn, .btn-group-vertical > .btn-group + .btn-group {
  margin-top: -1px;
  margin-left: 0; }

.btn-group-vertical > .btn:not(:first-child):not(:last-child) {
  border-radius: 0; }

.btn-group-vertical > .btn:first-child:not(:last-child) {
  border-top-right-radius: 4px;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.btn-group-vertical > .btn:last-child:not(:first-child) {
  border-bottom-left-radius: 4px;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.btn-group-vertical > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0; }

.btn-group-vertical > .btn-group:first-child:not(:last-child) > .btn:last-child, .btn-group-vertical > .btn-group:first-child:not(:last-child) > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.btn-group-vertical > .btn-group:last-child:not(:first-child) > .btn:first-child {
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.btn-group-justified {
  display: table;
  width: 100%;
  table-layout: fixed;
  border-collapse: separate; }

.btn-group-justified > .btn, .btn-group-justified > .btn-group {
  float: none;
  display: table-cell;
  width: 1%; }

.btn-group-justified > .btn-group .btn {
  width: 100%; }

[data-toggle=buttons] > .btn > input[type=radio], [data-toggle=buttons] > .btn > input[type=checkbox] {
  display: none; }

.input-group {
  position: relative;
  display: table;
  border-collapse: separate; }

.input-group[class*=col-] {
  float: none;
  padding-left: 0;
  padding-right: 0; }

.input-group .form-control {
  position: relative;
  z-index: 2;
  float: left;
  width: 100%;
  margin-bottom: 0; }

.input-group-lg > .form-control, .input-group-lg > .input-group-addon, .input-group-lg > .input-group-btn > .btn {
  height: 46px;
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

select.input-group-lg > .form-control, select.input-group-lg > .input-group-addon, select.input-group-lg > .input-group-btn > .btn {
  height: 46px;
  line-height: 46px; }

textarea.input-group-lg > .form-control, textarea.input-group-lg > .input-group-addon, textarea.input-group-lg > .input-group-btn > .btn, select[multiple].input-group-lg > .form-control, select[multiple].input-group-lg > .input-group-addon, select[multiple].input-group-lg > .input-group-btn > .btn {
  height: auto; }

.input-group-sm > .form-control, .input-group-sm > .input-group-addon, .input-group-sm > .input-group-btn > .btn {
  height: 30px;
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

select.input-group-sm > .form-control, select.input-group-sm > .input-group-addon, select.input-group-sm > .input-group-btn > .btn {
  height: 30px;
  line-height: 30px; }

textarea.input-group-sm > .form-control, textarea.input-group-sm > .input-group-addon, textarea.input-group-sm > .input-group-btn > .btn, select[multiple].input-group-sm > .form-control, select[multiple].input-group-sm > .input-group-addon, select[multiple].input-group-sm > .input-group-btn > .btn {
  height: auto; }

.input-group-addon, .input-group-btn, .input-group .form-control {
  display: table-cell; }

.input-group-addon:not(:first-child):not(:last-child), .input-group-btn:not(:first-child):not(:last-child), .input-group .form-control:not(:first-child):not(:last-child) {
  border-radius: 0; }

.input-group-addon, .input-group-btn {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle; }

.input-group-addon {
  padding: 6px 12px;
  font-size: 14px;
  font-weight: 400;
  line-height: 1;
  color: #555;
  text-align: center;
  background-color: #eee;
  border: 1px solid #ccc;
  border-radius: 4px; }

.input-group-addon.input-sm {
  padding: 5px 10px;
  font-size: 12px;
  border-radius: 3px; }

.input-group-addon.input-lg {
  padding: 10px 16px;
  font-size: 18px;
  border-radius: 6px; }

.input-group-addon input[type=radio], .input-group-addon input[type=checkbox] {
  margin-top: 0; }

.input-group .form-control:first-child, .input-group-addon:first-child, .input-group-btn:first-child > .btn, .input-group-btn:first-child > .btn-group > .btn, .input-group-btn:first-child > .dropdown-toggle, .input-group-btn:last-child > .btn:not(:last-child):not(.dropdown-toggle), .input-group-btn:last-child > .btn-group:not(:last-child) > .btn {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.input-group-addon:first-child {
  border-right: 0; }

.input-group .form-control:last-child, .input-group-addon:last-child, .input-group-btn:last-child > .btn, .input-group-btn:last-child > .btn-group > .btn, .input-group-btn:last-child > .dropdown-toggle, .input-group-btn:first-child > .btn:not(:first-child), .input-group-btn:first-child > .btn-group:not(:first-child) > .btn {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.input-group-addon:last-child {
  border-left: 0; }

.input-group-btn {
  position: relative;
  font-size: 0;
  white-space: nowrap; }

.input-group-btn > .btn {
  position: relative; }

.input-group-btn > .btn + .btn {
  margin-left: -1px; }

.input-group-btn > .btn:hover, .input-group-btn > .btn:focus, .input-group-btn > .btn:active {
  z-index: 2; }

.input-group-btn:first-child > .btn, .input-group-btn:first-child > .btn-group {
  margin-right: -1px; }

.input-group-btn:last-child > .btn, .input-group-btn:last-child > .btn-group {
  margin-left: -1px; }

.nav {
  margin-bottom: 0;
  padding-left: 0;
  list-style: none; }

.nav > li {
  position: relative;
  display: block; }

.nav > li > a {
  position: relative;
  display: block;
  padding: 10px 15px; }

.nav > li > a:hover, .nav > li > a:focus {
  text-decoration: none;
  background-color: #eee; }

.nav > li.disabled > a {
  color: #999; }

.nav > li.disabled > a:hover, .nav > li.disabled > a:focus {
  color: #999;
  text-decoration: none;
  background-color: transparent;
  cursor: not-allowed; }

.nav .open > a, .nav .open > a:hover, .nav .open > a:focus {
  background-color: #eee;
  border-color: #428bca; }

.nav .nav-divider {
  height: 1px;
  margin: 9px 0;
  overflow: hidden;
  background-color: #e5e5e5; }

.nav > li > a > img {
  max-width: none; }

.nav-tabs {
  border-bottom: 1px solid #ddd; }

.nav-tabs > li {
  float: left;
  margin-bottom: -1px; }

.nav-tabs > li > a {
  margin-right: 2px;
  line-height: 1.42857143;
  border: 1px solid transparent;
  border-radius: 4px 4px 0 0; }

.nav-tabs > li > a:hover {
  border-color: #eee #eee #ddd; }

.nav-tabs > li.active > a, .nav-tabs > li.active > a:hover, .nav-tabs > li.active > a:focus {
  color: #555;
  background-color: #fff;
  border: 1px solid #ddd;
  border-bottom-color: transparent;
  cursor: default; }

.nav-tabs.nav-justified {
  width: 100%;
  border-bottom: 0; }

.nav-tabs.nav-justified > li {
  float: none; }

.nav-tabs.nav-justified > li > a {
  text-align: center;
  margin-bottom: 5px; }

.nav-tabs.nav-justified > .dropdown .dropdown-menu {
  top: auto;
  left: auto; }

@media (min-width: 768px) {
  .nav-tabs.nav-justified > li {
    display: table-cell;
    width: 1%; }

  .nav-tabs.nav-justified > li > a {
    margin-bottom: 0; } }
.nav-tabs.nav-justified > li > a {
  margin-right: 0;
  border-radius: 4px; }

.nav-tabs.nav-justified > .active > a, .nav-tabs.nav-justified > .active > a:hover, .nav-tabs.nav-justified > .active > a:focus {
  border: 1px solid #ddd; }

@media (min-width: 768px) {
  .nav-tabs.nav-justified > li > a {
    border-bottom: 1px solid #ddd;
    border-radius: 4px 4px 0 0; }

  .nav-tabs.nav-justified > .active > a, .nav-tabs.nav-justified > .active > a:hover, .nav-tabs.nav-justified > .active > a:focus {
    border-bottom-color: #fff; } }
.nav-pills > li {
  float: left; }

.nav-pills > li > a {
  border-radius: 4px; }

.nav-pills > li + li {
  margin-left: 2px; }

.nav-pills > li.active > a, .nav-pills > li.active > a:hover, .nav-pills > li.active > a:focus {
  color: #fff;
  background-color: #428bca; }

.nav-stacked > li {
  float: none; }

.nav-stacked > li + li {
  margin-top: 2px;
  margin-left: 0; }

.nav-justified {
  width: 100%; }

.nav-justified > li {
  float: none; }

.nav-justified > li > a {
  text-align: center;
  margin-bottom: 5px; }

.nav-justified > .dropdown .dropdown-menu {
  top: auto;
  left: auto; }

@media (min-width: 768px) {
  .nav-justified > li {
    display: table-cell;
    width: 1%; }

  .nav-justified > li > a {
    margin-bottom: 0; } }
.nav-tabs-justified {
  border-bottom: 0; }

.nav-tabs-justified > li > a {
  margin-right: 0;
  border-radius: 4px; }

.nav-tabs-justified > .active > a, .nav-tabs-justified > .active > a:hover, .nav-tabs-justified > .active > a:focus {
  border: 1px solid #ddd; }

@media (min-width: 768px) {
  .nav-tabs-justified > li > a {
    border-bottom: 1px solid #ddd;
    border-radius: 4px 4px 0 0; }

  .nav-tabs-justified > .active > a, .nav-tabs-justified > .active > a:hover, .nav-tabs-justified > .active > a:focus {
    border-bottom-color: #fff; } }
.tab-content > .tab-pane {
  display: none; }

.tab-content > .active {
  display: block; }

.nav-tabs .dropdown-menu {
  margin-top: -1px;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.navbar {
  position: relative;
  min-height: 50px;
  margin-bottom: 20px;
  border: 1px solid transparent; }

@media (min-width: 768px) {
  .navbar {
    border-radius: 4px; } }
@media (min-width: 768px) {
  .navbar-header {
    float: left; } }
.navbar-collapse {
  max-height: 340px;
  overflow-x: visible;
  padding-right: 15px;
  padding-left: 15px;
  border-top: 1px solid transparent;
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
  -webkit-overflow-scrolling: touch; }

.navbar-collapse.in {
  overflow-y: auto; }

@media (min-width: 768px) {
  .navbar-collapse {
    width: auto;
    border-top: 0;
    box-shadow: none; }

  .navbar-collapse.collapse {
    display: block !important;
    height: auto !important;
    padding-bottom: 0;
    overflow: visible !important; }

  .navbar-collapse.in {
    overflow-y: visible; }

  .navbar-fixed-top .navbar-collapse, .navbar-static-top .navbar-collapse, .navbar-fixed-bottom .navbar-collapse {
    padding-left: 0;
    padding-right: 0; } }
.container > .navbar-header, .container-fluid > .navbar-header, .container > .navbar-collapse, .container-fluid > .navbar-collapse {
  margin-right: -15px;
  margin-left: -15px; }

@media (min-width: 768px) {
  .container > .navbar-header, .container-fluid > .navbar-header, .container > .navbar-collapse, .container-fluid > .navbar-collapse {
    margin-right: 0;
    margin-left: 0; } }
.navbar-static-top {
  z-index: 1000;
  border-width: 0 0 1px; }

@media (min-width: 768px) {
  .navbar-static-top {
    border-radius: 0; } }
.navbar-fixed-top, .navbar-fixed-bottom {
  position: fixed;
  right: 0;
  left: 0;
  z-index: 1030; }

@media (min-width: 768px) {
  .navbar-fixed-top, .navbar-fixed-bottom {
    border-radius: 0; } }
.navbar-fixed-top {
  top: 0;
  border-width: 0 0 1px; }

.navbar-fixed-bottom {
  bottom: 0;
  margin-bottom: 0;
  border-width: 1px 0 0; }

.navbar-brand {
  float: left;
  padding: 15px;
  font-size: 18px;
  line-height: 20px;
  height: 50px; }

.navbar-brand:hover, .navbar-brand:focus {
  text-decoration: none; }

@media (min-width: 768px) {
  .navbar > .container .navbar-brand, .navbar > .container-fluid .navbar-brand {
    margin-left: -15px; } }
.navbar-toggle {
  position: relative;
  float: right;
  margin-right: 15px;
  padding: 9px 10px;
  margin-top: 8px;
  margin-bottom: 8px;
  background-color: transparent;
  background-image: none;
  border: 1px solid transparent;
  border-radius: 4px; }

.navbar-toggle:focus {
  outline: 0; }

.navbar-toggle .icon-bar {
  display: block;
  width: 22px;
  height: 2px;
  border-radius: 1px; }

.navbar-toggle .icon-bar + .icon-bar {
  margin-top: 4px; }

@media (min-width: 768px) {
  .navbar-toggle {
    display: none; } }
.navbar-nav {
  margin: 7.5px -15px; }

.navbar-nav > li > a {
  padding-top: 10px;
  padding-bottom: 10px;
  line-height: 20px; }

@media (max-width: 767px) {
  .navbar-nav .open .dropdown-menu {
    position: static;
    float: none;
    width: auto;
    margin-top: 0;
    background-color: transparent;
    border: 0;
    box-shadow: none; }

  .navbar-nav .open .dropdown-menu > li > a, .navbar-nav .open .dropdown-menu .dropdown-header {
    padding: 5px 15px 5px 25px; }

  .navbar-nav .open .dropdown-menu > li > a {
    line-height: 20px; }

  .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-nav .open .dropdown-menu > li > a:focus {
    background-image: none; } }
@media (min-width: 768px) {
  .navbar-nav {
    float: left;
    margin: 0; }

  .navbar-nav > li {
    float: left; }

  .navbar-nav > li > a {
    padding-top: 15px;
    padding-bottom: 15px; }

  .navbar-nav.navbar-right:last-child {
    margin-right: -15px; } }
@media (min-width: 768px) {
  .navbar-left {
    float: left !important; }

  .navbar-right {
    float: right !important; } }
.navbar-form {
  margin-left: -15px;
  margin-right: -15px;
  padding: 10px 15px;
  border-top: 1px solid transparent;
  border-bottom: 1px solid transparent;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
  margin-top: 8px;
  margin-bottom: 8px; }

@media (min-width: 768px) {
  .navbar-form .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle; }

  .navbar-form .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle; }

  .navbar-form .input-group > .form-control {
    width: 100%; }

  .navbar-form .control-label {
    margin-bottom: 0;
    vertical-align: middle; }

  .navbar-form .radio, .navbar-form .checkbox {
    display: inline-block;
    margin-top: 0;
    margin-bottom: 0;
    padding-left: 0;
    vertical-align: middle; }

  .navbar-form .radio input[type=radio], .navbar-form .checkbox input[type=checkbox] {
    float: none;
    margin-left: 0; }

  .navbar-form .has-feedback .form-control-feedback {
    top: 0; } }
@media (max-width: 767px) {
  .navbar-form .form-group {
    margin-bottom: 5px; } }
@media (min-width: 768px) {
  .navbar-form {
    width: auto;
    border: 0;
    margin-left: 0;
    margin-right: 0;
    padding-top: 0;
    padding-bottom: 0;
    -webkit-box-shadow: none;
    box-shadow: none; }

  .navbar-form.navbar-right:last-child {
    margin-right: -15px; } }
.navbar-nav > li > .dropdown-menu {
  margin-top: 0;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.navbar-fixed-bottom .navbar-nav > li > .dropdown-menu {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.navbar-btn {
  margin-top: 8px;
  margin-bottom: 8px; }

.navbar-btn.btn-sm {
  margin-top: 10px;
  margin-bottom: 10px; }

.navbar-btn.btn-xs {
  margin-top: 14px;
  margin-bottom: 14px; }

.navbar-text {
  margin-top: 15px;
  margin-bottom: 15px; }

@media (min-width: 768px) {
  .navbar-text {
    float: left;
    margin-left: 15px;
    margin-right: 15px; }

  .navbar-text.navbar-right:last-child {
    margin-right: 0; } }
.navbar-default {
  background-color: #f8f8f8;
  border-color: #e7e7e7; }

.navbar-default .navbar-brand {
  color: #777; }

.navbar-default .navbar-brand:hover, .navbar-default .navbar-brand:focus {
  color: #5e5e5e;
  background-color: transparent; }

.navbar-default .navbar-text {
  color: #777; }

.navbar-default .navbar-nav > li > a {
  color: #777; }

.navbar-default .navbar-nav > li > a:hover, .navbar-default .navbar-nav > li > a:focus {
  color: #333;
  background-color: transparent; }

.navbar-default .navbar-nav > .active > a, .navbar-default .navbar-nav > .active > a:hover, .navbar-default .navbar-nav > .active > a:focus {
  color: #555;
  background-color: #e7e7e7; }

.navbar-default .navbar-nav > .disabled > a, .navbar-default .navbar-nav > .disabled > a:hover, .navbar-default .navbar-nav > .disabled > a:focus {
  color: #ccc;
  background-color: transparent; }

.navbar-default .navbar-toggle {
  border-color: #ddd; }

.navbar-default .navbar-toggle:hover, .navbar-default .navbar-toggle:focus {
  background-color: #ddd; }

.navbar-default .navbar-toggle .icon-bar {
  background-color: #888; }

.navbar-default .navbar-collapse, .navbar-default .navbar-form {
  border-color: #e7e7e7; }

.navbar-default .navbar-nav > .open > a, .navbar-default .navbar-nav > .open > a:hover, .navbar-default .navbar-nav > .open > a:focus {
  background-color: #e7e7e7;
  color: #555; }

@media (max-width: 767px) {
  .navbar-default .navbar-nav .open .dropdown-menu > li > a {
    color: #777; }

  .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #333;
    background-color: transparent; }

  .navbar-default .navbar-nav .open .dropdown-menu > .active > a, .navbar-default .navbar-nav .open .dropdown-menu > .active > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #555;
    background-color: #e7e7e7; }

  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a, .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #ccc;
    background-color: transparent; } }
.navbar-default .navbar-link {
  color: #777; }

.navbar-default .navbar-link:hover {
  color: #333; }

.navbar-inverse {
  background-color: transparent;
  border: medium none;
  margin-bottom: 0; }

.navbar-inverse .navbar-brand {
  color: #999; }

.navbar-inverse .navbar-brand:hover, .navbar-inverse .navbar-brand:focus {
  color: #fff;
  background-color: transparent; }

.navbar-inverse .navbar-text {
  color: #999; }

.navbar-inverse .navbar-nav > li > a {
  color: #999; }

.navbar-inverse .navbar-nav > li > a:hover,
.navbar-inverse .navbar-nav > li > a:focus {
  color: #1788ca;
  background-color: transparent; }

.navbar-inverse .navbar-nav > .active > a, .navbar-inverse .navbar-nav > .active > a:hover, .navbar-inverse .navbar-nav > .active > a:focus {
  color: #fff;
  background-color: #080808; }

.navbar-inverse .navbar-nav > .disabled > a,
.navbar-inverse .navbar-nav > .disabled > a:hover,
.navbar-inverse .navbar-nav > .disabled > a:focus {
  color: #444;
  background-color: transparent; }

.navbar-inverse .navbar-toggle {
  border-color: #333; }

.navbar-inverse .navbar-toggle:hover, .navbar-inverse .navbar-toggle:focus {
  background-color: #333; }

.navbar-inverse .navbar-toggle .icon-bar {
  background-color: #fff; }

.navbar-inverse .navbar-collapse, .navbar-inverse .navbar-form {
  border-color: #101010; }

.navbar-inverse .navbar-nav > .open > a, .navbar-inverse .navbar-nav > .open > a:hover, .navbar-inverse .navbar-nav > .open > a:focus {
  background-color: #080808;
  color: #fff; }

@media (max-width: 767px) {
  .navbar-inverse .navbar-nav .open .dropdown-menu > .dropdown-header {
    border-color: #080808; }

  .navbar-inverse .navbar-nav .open .dropdown-menu .divider {
    background-color: #080808; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a {
    color: #999; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #fff;
    background-color: transparent; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a, .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #fff;
    background-color: #080808; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a, .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #444;
    background-color: transparent; } }
.navbar-inverse .navbar-link {
  color: #999; }

.navbar-inverse .navbar-link:hover {
  color: #fff; }

.breadcrumb {
  padding: 8px 15px;
  margin-bottom: 20px;
  list-style: none;
  background-color: #f5f5f5;
  border-radius: 4px; }

.breadcrumb > li {
  display: inline-block; }

.breadcrumb > li + li:before {
  content: "/\00a0";
  padding: 0 5px;
  color: #ccc; }

.breadcrumb > .active {
  color: #999; }

.pagination {
  display: inline-block;
  padding-left: 0;
  margin: 20px 0;
  border-radius: 4px; }

.pagination > li {
  display: inline; }

.pagination > li > a, .pagination > li > span {
  position: relative;
  float: left;
  padding: 6px 12px;
  line-height: 1.42857143;
  text-decoration: none;
  color: #428bca;
  background-color: #fff;
  border: 1px solid #ddd;
  margin-left: -1px; }

.pagination > li:first-child > a, .pagination > li:first-child > span {
  margin-left: 0;
  border-bottom-left-radius: 4px;
  border-top-left-radius: 4px; }

.pagination > li:last-child > a, .pagination > li:last-child > span {
  border-bottom-right-radius: 4px;
  border-top-right-radius: 4px; }

.pagination > li > a:hover, .pagination > li > span:hover, .pagination > li > a:focus, .pagination > li > span:focus {
  color: #2a6496;
  background-color: #eee;
  border-color: #ddd; }

.pagination > .active > a, .pagination > .active > span, .pagination > .active > a:hover, .pagination > .active > span:hover, .pagination > .active > a:focus, .pagination > .active > span:focus {
  z-index: 2;
  color: #fff;
  background-color: #428bca;
  border-color: #428bca;
  cursor: default; }

.pagination > .disabled > span, .pagination > .disabled > span:hover, .pagination > .disabled > span:focus, .pagination > .disabled > a, .pagination > .disabled > a:hover, .pagination > .disabled > a:focus {
  color: #999;
  background-color: #fff;
  border-color: #ddd;
  cursor: not-allowed; }

.pagination-lg > li > a, .pagination-lg > li > span {
  padding: 10px 16px;
  font-size: 18px; }

.pagination-lg > li:first-child > a, .pagination-lg > li:first-child > span {
  border-bottom-left-radius: 6px;
  border-top-left-radius: 6px; }

.pagination-lg > li:last-child > a, .pagination-lg > li:last-child > span {
  border-bottom-right-radius: 6px;
  border-top-right-radius: 6px; }

.pagination-sm > li > a, .pagination-sm > li > span {
  padding: 5px 10px;
  font-size: 12px; }

.pagination-sm > li:first-child > a, .pagination-sm > li:first-child > span {
  border-bottom-left-radius: 3px;
  border-top-left-radius: 3px; }

.pagination-sm > li:last-child > a, .pagination-sm > li:last-child > span {
  border-bottom-right-radius: 3px;
  border-top-right-radius: 3px; }

.pager {
  padding-left: 0;
  margin: 20px 0;
  list-style: none;
  text-align: center; }

.pager li {
  display: inline; }

.pager li > a, .pager li > span {
  display: inline-block;
  padding: 5px 14px;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 15px; }

.pager li > a:hover, .pager li > a:focus {
  text-decoration: none;
  background-color: #eee; }

.pager .next > a, .pager .next > span {
  float: right; }

.pager .previous > a, .pager .previous > span {
  float: left; }

.pager .disabled > a, .pager .disabled > a:hover, .pager .disabled > a:focus, .pager .disabled > span {
  color: #999;
  background-color: #fff;
  cursor: not-allowed; }

.label {
  display: inline;
  padding: .2em .6em .3em;
  font-size: 75%;
  font-weight: 700;
  line-height: 1;
  color: #fff;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: .25em; }

.label[href]:hover, .label[href]:focus {
  color: #fff;
  text-decoration: none;
  cursor: pointer; }

.label:empty {
  display: none; }

.btn .label {
  position: relative;
  top: -1px; }

.label-default {
  background-color: #999; }

.label-default[href]:hover, .label-default[href]:focus {
  background-color: gray; }

.label-primary {
  background-color: #428bca; }

.label-primary[href]:hover, .label-primary[href]:focus {
  background-color: #3071a9; }

.label-success {
  background-color: #5cb85c; }

.label-success[href]:hover, .label-success[href]:focus {
  background-color: #449d44; }

.label-info {
  background-color: #5bc0de; }

.label-info[href]:hover, .label-info[href]:focus {
  background-color: #31b0d5; }

.label-warning {
  background-color: #f0ad4e; }

.label-warning[href]:hover, .label-warning[href]:focus {
  background-color: #ec971f; }

.label-danger {
  background-color: #d9534f; }

.label-danger[href]:hover, .label-danger[href]:focus {
  background-color: #c9302c; }

.badge {
  display: inline-block;
  min-width: 10px;
  padding: 3px 7px;
  font-size: 12px;
  font-weight: 700;
  color: #fff;
  line-height: 1;
  vertical-align: baseline;
  white-space: nowrap;
  text-align: center;
  background-color: #999;
  border-radius: 10px; }

.badge:empty {
  display: none; }

.btn .badge {
  position: relative;
  top: -1px; }

.btn-xs .badge {
  top: 0;
  padding: 1px 5px; }

a.badge:hover, a.badge:focus {
  color: #fff;
  text-decoration: none;
  cursor: pointer; }

a.list-group-item.active > .badge, .nav-pills > .active > a > .badge {
  color: #428bca;
  background-color: #fff; }

.nav-pills > li > a > .badge {
  margin-left: 3px; }

.jumbotron {
  padding: 30px;
  margin-bottom: 30px;
  color: inherit;
  background-color: #eee; }

.jumbotron h1, .jumbotron .h1 {
  color: inherit; }

.jumbotron p {
  margin-bottom: 15px;
  font-size: 21px;
  font-weight: 200; }

.container .jumbotron {
  border-radius: 6px; }

.jumbotron .container {
  max-width: 100%; }

@media screen and (min-width: 768px) {
  .jumbotron {
    padding-top: 48px;
    padding-bottom: 48px; }

  .container .jumbotron {
    padding-left: 60px;
    padding-right: 60px; }

  .jumbotron h1, .jumbotron .h1 {
    font-size: 63px; } }
.thumbnail {
  display: block;
  padding: 4px;
  margin-bottom: 20px;
  line-height: 1.42857143;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  -webkit-transition: all .2s ease-in-out;
  transition: all .2s ease-in-out; }

.thumbnail > img, .thumbnail a > img {
  margin-left: auto;
  margin-right: auto; }

a.thumbnail:hover, a.thumbnail:focus, a.thumbnail.active {
  border-color: #428bca; }

.thumbnail .caption {
  padding: 9px;
  color: #333; }

.alert {
  padding: 15px;
  margin-bottom: 20px;
  border: 1px solid transparent;
  border-radius: 4px; }

.alert h4 {
  margin-top: 0;
  color: inherit; }

.alert .alert-link {
  font-weight: 700; }

.alert > p, .alert > ul {
  margin-bottom: 0; }

.alert > p + p {
  margin-top: 5px; }

.alert-dismissable {
  padding-right: 35px; }

.alert-dismissable .close {
  position: relative;
  top: -2px;
  right: -21px;
  color: inherit; }

.alert-success {
  background-color: #dff0d8;
  border-color: #d6e9c6;
  color: #3c763d; }

.alert-success hr {
  border-top-color: #c9e2b3; }

.alert-success .alert-link {
  color: #2b542c; }

.alert-info {
  background-color: #d9edf7;
  border-color: #bce8f1;
  color: #31708f; }

.alert-info hr {
  border-top-color: #a6e1ec; }

.alert-info .alert-link {
  color: #245269; }

.alert-warning {
  background-color: #fcf8e3;
  border-color: #faebcc;
  color: #8a6d3b; }

.alert-warning hr {
  border-top-color: #f7e1b5; }

.alert-warning .alert-link {
  color: #66512c; }

.alert-danger {
  background-color: #f2dede;
  border-color: #ebccd1;
  color: #a94442; }

.alert-danger hr {
  border-top-color: #e4b9c0; }

.alert-danger .alert-link {
  color: #843534; }

@-webkit-keyframes progress-bar-stripes {
  from {
    background-position: 40px 0; }
  to {
    background-position: 0 0; } }
@keyframes progress-bar-stripes {
  from {
    background-position: 40px 0; }
  to {
    background-position: 0 0; } }
.progress {
  overflow: hidden;
  height: 20px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
  box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1); }

.progress-bar {
  float: left;
  width: 0;
  height: 100%;
  font-size: 12px;
  line-height: 20px;
  color: #fff;
  text-align: center;
  background-color: #428bca;
  -webkit-box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  -webkit-transition: width .6s ease;
  transition: width .6s ease; }

.progress-striped .progress-bar {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-size: 40px 40px; }

.progress.active .progress-bar {
  -webkit-animation: progress-bar-stripes 2s linear infinite;
  animation: progress-bar-stripes 2s linear infinite; }

.progress-bar-success {
  background-color: #5cb85c; }

.progress-striped .progress-bar-success {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-info {
  background-color: #5bc0de; }

.progress-striped .progress-bar-info {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-warning {
  background-color: #f0ad4e; }

.progress-striped .progress-bar-warning {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-danger {
  background-color: #d9534f; }

.progress-striped .progress-bar-danger {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.media, .media-body {
  overflow: hidden;
  zoom: 1; }

.media, .media .media {
  margin-top: 15px; }

.media:first-child {
  margin-top: 0; }

.media-object {
  display: block; }

.media-heading {
  margin: 0 0 5px; }

.media > .pull-left {
  margin-right: 10px; }

.media > .pull-right {
  margin-left: 10px; }

.media-list {
  padding-left: 0;
  list-style: none; }

.list-group {
  margin-bottom: 20px;
  padding-left: 0; }

.list-group-item {
  position: relative;
  display: block;
  padding: 10px 15px;
  margin-bottom: -1px;
  background-color: #fff;
  border: 1px solid #ddd; }

.list-group-item:first-child {
  border-top-right-radius: 4px;
  border-top-left-radius: 4px; }

.list-group-item:last-child {
  margin-bottom: 0;
  border-bottom-right-radius: 4px;
  border-bottom-left-radius: 4px; }

.list-group-item > .badge {
  float: right; }

.list-group-item > .badge + .badge {
  margin-right: 5px; }

a.list-group-item {
  color: #555; }

a.list-group-item .list-group-item-heading {
  color: #333; }

a.list-group-item:hover, a.list-group-item:focus {
  text-decoration: none;
  background-color: #f5f5f5; }

a.list-group-item.active, a.list-group-item.active:hover, a.list-group-item.active:focus {
  z-index: 2;
  color: #fff;
  background-color: #428bca;
  border-color: #428bca; }

a.list-group-item.active .list-group-item-heading, a.list-group-item.active:hover .list-group-item-heading, a.list-group-item.active:focus .list-group-item-heading {
  color: inherit; }

a.list-group-item.active .list-group-item-text, a.list-group-item.active:hover .list-group-item-text, a.list-group-item.active:focus .list-group-item-text {
  color: #e1edf7; }

.list-group-item-success {
  color: #3c763d;
  background-color: #dff0d8; }

a.list-group-item-success {
  color: #3c763d; }

a.list-group-item-success .list-group-item-heading {
  color: inherit; }

a.list-group-item-success:hover, a.list-group-item-success:focus {
  color: #3c763d;
  background-color: #d0e9c6; }

a.list-group-item-success.active, a.list-group-item-success.active:hover, a.list-group-item-success.active:focus {
  color: #fff;
  background-color: #3c763d;
  border-color: #3c763d; }

.list-group-item-info {
  color: #31708f;
  background-color: #d9edf7; }

a.list-group-item-info {
  color: #31708f; }

a.list-group-item-info .list-group-item-heading {
  color: inherit; }

a.list-group-item-info:hover, a.list-group-item-info:focus {
  color: #31708f;
  background-color: #c4e3f3; }

a.list-group-item-info.active, a.list-group-item-info.active:hover, a.list-group-item-info.active:focus {
  color: #fff;
  background-color: #31708f;
  border-color: #31708f; }

.list-group-item-warning {
  color: #8a6d3b;
  background-color: #fcf8e3; }

a.list-group-item-warning {
  color: #8a6d3b; }

a.list-group-item-warning .list-group-item-heading {
  color: inherit; }

a.list-group-item-warning:hover, a.list-group-item-warning:focus {
  color: #8a6d3b;
  background-color: #faf2cc; }

a.list-group-item-warning.active, a.list-group-item-warning.active:hover, a.list-group-item-warning.active:focus {
  color: #fff;
  background-color: #8a6d3b;
  border-color: #8a6d3b; }

.list-group-item-danger {
  color: #a94442;
  background-color: #f2dede; }

a.list-group-item-danger {
  color: #a94442; }

a.list-group-item-danger .list-group-item-heading {
  color: inherit; }

a.list-group-item-danger:hover, a.list-group-item-danger:focus {
  color: #a94442;
  background-color: #ebcccc; }

a.list-group-item-danger.active, a.list-group-item-danger.active:hover, a.list-group-item-danger.active:focus {
  color: #fff;
  background-color: #a94442;
  border-color: #a94442; }

.list-group-item-heading {
  margin-top: 0;
  margin-bottom: 5px; }

.list-group-item-text {
  margin-bottom: 0;
  line-height: 1.3; }

.panel {
  margin-bottom: 20px;
  background-color: #fff;
  border: 1px solid transparent;
  border-radius: 4px;
  -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05); }

.panel-body {
  padding: 15px; }

.panel-heading {
  padding: 10px 15px;
  border-bottom: 1px solid transparent;
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }

.panel-heading > .dropdown .dropdown-toggle {
  color: inherit; }

.panel-title {
  margin-top: 0;
  margin-bottom: 0;
  font-size: 16px;
  color: inherit; }

.panel-title > a {
  color: inherit; }

.panel-footer {
  padding: 10px 15px;
  background-color: #f5f5f5;
  border-top: 1px solid #ddd;
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel > .list-group {
  margin-bottom: 0; }

.panel > .list-group .list-group-item {
  border-width: 1px 0;
  border-radius: 0; }

.panel > .list-group:first-child .list-group-item:first-child {
  border-top: 0;
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }

.panel > .list-group:last-child .list-group-item:last-child {
  border-bottom: 0;
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel-heading + .list-group .list-group-item:first-child {
  border-top-width: 0; }

.panel > .table, .panel > .table-responsive > .table {
  margin-bottom: 0; }

.panel > .table:first-child, .panel > .table-responsive:first-child > .table:first-child {
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }

.panel > .table:first-child > thead:first-child > tr:first-child td:first-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child td:first-child, .panel > .table:first-child > tbody:first-child > tr:first-child td:first-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child td:first-child, .panel > .table:first-child > thead:first-child > tr:first-child th:first-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child th:first-child, .panel > .table:first-child > tbody:first-child > tr:first-child th:first-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child th:first-child {
  border-top-left-radius: 3px; }

.panel > .table:first-child > thead:first-child > tr:first-child td:last-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child td:last-child, .panel > .table:first-child > tbody:first-child > tr:first-child td:last-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child td:last-child, .panel > .table:first-child > thead:first-child > tr:first-child th:last-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child th:last-child, .panel > .table:first-child > tbody:first-child > tr:first-child th:last-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child th:last-child {
  border-top-right-radius: 3px; }

.panel > .table:last-child, .panel > .table-responsive:last-child > .table:last-child {
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel > .table:last-child > tbody:last-child > tr:last-child td:first-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child td:first-child, .panel > .table:last-child > tfoot:last-child > tr:last-child td:first-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child td:first-child, .panel > .table:last-child > tbody:last-child > tr:last-child th:first-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child th:first-child, .panel > .table:last-child > tfoot:last-child > tr:last-child th:first-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child th:first-child {
  border-bottom-left-radius: 3px; }

.panel > .table:last-child > tbody:last-child > tr:last-child td:last-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child td:last-child, .panel > .table:last-child > tfoot:last-child > tr:last-child td:last-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child td:last-child, .panel > .table:last-child > tbody:last-child > tr:last-child th:last-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child th:last-child, .panel > .table:last-child > tfoot:last-child > tr:last-child th:last-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child th:last-child {
  border-bottom-right-radius: 3px; }

.panel > .panel-body + .table, .panel > .panel-body + .table-responsive {
  border-top: 1px solid #ddd; }

.panel > .table > tbody:first-child > tr:first-child th, .panel > .table > tbody:first-child > tr:first-child td {
  border-top: 0; }

.panel > .table-bordered, .panel > .table-responsive > .table-bordered {
  border: 0; }

.panel > .table-bordered > thead > tr > th:first-child, .panel > .table-responsive > .table-bordered > thead > tr > th:first-child, .panel > .table-bordered > tbody > tr > th:first-child, .panel > .table-responsive > .table-bordered > tbody > tr > th:first-child, .panel > .table-bordered > tfoot > tr > th:first-child, .panel > .table-responsive > .table-bordered > tfoot > tr > th:first-child, .panel > .table-bordered > thead > tr > td:first-child, .panel > .table-responsive > .table-bordered > thead > tr > td:first-child, .panel > .table-bordered > tbody > tr > td:first-child, .panel > .table-responsive > .table-bordered > tbody > tr > td:first-child, .panel > .table-bordered > tfoot > tr > td:first-child, .panel > .table-responsive > .table-bordered > tfoot > tr > td:first-child {
  border-left: 0; }

.panel > .table-bordered > thead > tr > th:last-child, .panel > .table-responsive > .table-bordered > thead > tr > th:last-child, .panel > .table-bordered > tbody > tr > th:last-child, .panel > .table-responsive > .table-bordered > tbody > tr > th:last-child, .panel > .table-bordered > tfoot > tr > th:last-child, .panel > .table-responsive > .table-bordered > tfoot > tr > th:last-child, .panel > .table-bordered > thead > tr > td:last-child, .panel > .table-responsive > .table-bordered > thead > tr > td:last-child, .panel > .table-bordered > tbody > tr > td:last-child, .panel > .table-responsive > .table-bordered > tbody > tr > td:last-child, .panel > .table-bordered > tfoot > tr > td:last-child, .panel > .table-responsive > .table-bordered > tfoot > tr > td:last-child {
  border-right: 0; }

.panel > .table-bordered > thead > tr:first-child > td, .panel > .table-responsive > .table-bordered > thead > tr:first-child > td, .panel > .table-bordered > tbody > tr:first-child > td, .panel > .table-responsive > .table-bordered > tbody > tr:first-child > td, .panel > .table-bordered > thead > tr:first-child > th, .panel > .table-responsive > .table-bordered > thead > tr:first-child > th, .panel > .table-bordered > tbody > tr:first-child > th, .panel > .table-responsive > .table-bordered > tbody > tr:first-child > th {
  border-bottom: 0; }

.panel > .table-bordered > tbody > tr:last-child > td, .panel > .table-responsive > .table-bordered > tbody > tr:last-child > td, .panel > .table-bordered > tfoot > tr:last-child > td, .panel > .table-responsive > .table-bordered > tfoot > tr:last-child > td, .panel > .table-bordered > tbody > tr:last-child > th, .panel > .table-responsive > .table-bordered > tbody > tr:last-child > th, .panel > .table-bordered > tfoot > tr:last-child > th, .panel > .table-responsive > .table-bordered > tfoot > tr:last-child > th {
  border-bottom: 0; }

.panel > .table-responsive {
  border: 0;
  margin-bottom: 0; }

.panel-group {
  margin-bottom: 20px; }

.panel-group .panel {
  margin-bottom: 0;
  border-radius: 4px;
  overflow: hidden; }

.panel-group .panel + .panel {
  margin-top: 5px; }

.panel-group .panel-heading {
  border-bottom: 0; }

.panel-group .panel-heading + .panel-collapse .panel-body {
  border-top: 1px solid #ddd; }

.panel-group .panel-footer {
  border-top: 0; }

.panel-group .panel-footer + .panel-collapse .panel-body {
  border-bottom: 1px solid #ddd; }

.panel-default {
  border-color: #ddd; }

.panel-default > .panel-heading {
  color: #333;
  background-color: #f5f5f5;
  border-color: #ddd; }

.panel-default > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #ddd; }

.panel-default > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #ddd; }

.panel-primary {
  border-color: #428bca; }

.panel-primary > .panel-heading {
  color: #fff;
  background-color: #428bca;
  border-color: #428bca; }

.panel-primary > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #428bca; }

.panel-primary > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #428bca; }

.panel-success {
  border-color: #d6e9c6; }

.panel-success > .panel-heading {
  color: #3c763d;
  background-color: #dff0d8;
  border-color: #d6e9c6; }

.panel-success > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #d6e9c6; }

.panel-success > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #d6e9c6; }

.panel-info {
  border-color: #bce8f1; }

.panel-info > .panel-heading {
  color: #31708f;
  background-color: #d9edf7;
  border-color: #bce8f1; }

.panel-info > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #bce8f1; }

.panel-info > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #bce8f1; }

.panel-warning {
  border-color: #faebcc; }

.panel-warning > .panel-heading {
  color: #8a6d3b;
  background-color: #fcf8e3;
  border-color: #faebcc; }

.panel-warning > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #faebcc; }

.panel-warning > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #faebcc; }

.panel-danger {
  border-color: #ebccd1; }

.panel-danger > .panel-heading {
  color: #a94442;
  background-color: #f2dede;
  border-color: #ebccd1; }

.panel-danger > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #ebccd1; }

.panel-danger > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #ebccd1; }

.well {
  min-height: 20px;
  padding: 19px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border: 1px solid #e3e3e3;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05); }

.well blockquote {
  border-color: #ddd;
  border-color: rgba(0, 0, 0, 0.15); }

.well-lg {
  padding: 24px;
  border-radius: 6px; }

.well-sm {
  padding: 9px;
  border-radius: 3px; }

.close {
  float: right;
  font-size: 21px;
  font-weight: 700;
  line-height: 1;
  color: #000;
  text-shadow: 0 1px 0 #fff;
  opacity: .2;
  filter: alpha(opacity=20); }

.close:hover, .close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
  opacity: .5;
  filter: alpha(opacity=50); }

button.close {
  padding: 0;
  cursor: pointer;
  background: 0 0;
  border: 0;
  -webkit-appearance: none; }

.modal-open {
  overflow: hidden; }

.modal {
  display: none;
  overflow: auto;
  overflow-y: scroll;
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1050;
  -webkit-overflow-scrolling: touch;
  outline: 0; }

.modal.fade .modal-dialog {
  -webkit-transform: translate(0, -25%);
  -ms-transform: translate(0, -25%);
  transform: translate(0, -25%);
  -webkit-transition: -webkit-transform .3s ease-out;
  -moz-transition: -moz-transform .3s ease-out;
  -o-transition: -o-transform .3s ease-out;
  transition: transform .3s ease-out; }

.modal.in .modal-dialog {
  -webkit-transform: translate(0, 0);
  -ms-transform: translate(0, 0);
  transform: translate(0, 0); }

.modal-dialog {
  position: relative;
  width: auto;
  margin: 10px; }

.modal-content {
  position: relative;
  background-color: #fff;
  border: 1px solid #999;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 6px;
  -webkit-box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  background-clip: padding-box;
  outline: 0; }

.modal-backdrop {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1040;
  background-color: #000; }

.modal-backdrop.fade {
  opacity: 0;
  filter: alpha(opacity=0); }

.modal-backdrop.in {
  opacity: .5;
  filter: alpha(opacity=50); }

.modal-header {
  padding: 15px;
  border-bottom: 1px solid #e5e5e5;
  min-height: 16.42857143px; }

.modal-header .close {
  margin-top: -2px; }

.modal-title {
  margin: 0;
  line-height: 1.42857143; }

.modal-body {
  position: relative;
  padding: 20px; }

.modal-footer {
  margin-top: 15px;
  padding: 19px 20px 20px;
  text-align: right;
  border-top: 1px solid #e5e5e5; }

.modal-footer .btn + .btn {
  margin-left: 5px;
  margin-bottom: 0; }

.modal-footer .btn-group .btn + .btn {
  margin-left: -1px; }

.modal-footer .btn-block + .btn-block {
  margin-left: 0; }

@media (min-width: 768px) {
  .modal-dialog {
    width: 600px;
    margin: 30px auto; }

  .modal-content {
    -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5); }

  .modal-sm {
    width: 300px; } }
@media (min-width: 992px) {
  .modal-lg {
    width: 900px; } }
.tooltip {
  position: absolute;
  z-index: 1030;
  display: block;
  visibility: visible;
  font-size: 12px;
  line-height: 1.4;
  opacity: 0;
  filter: alpha(opacity=0); }

.tooltip.in {
  opacity: .9;
  filter: alpha(opacity=90); }

.tooltip.top {
  margin-top: -3px;
  padding: 5px 0; }

.tooltip.right {
  margin-left: 3px;
  padding: 0 5px; }

.tooltip.bottom {
  margin-top: 3px;
  padding: 5px 0; }

.tooltip.left {
  margin-left: -3px;
  padding: 0 5px; }

.tooltip-inner {
  max-width: 200px;
  padding: 3px 8px;
  color: #fff;
  text-align: center;
  text-decoration: none;
  background-color: #000;
  border-radius: 4px; }

.tooltip-arrow {
  position: absolute;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid; }

.tooltip.top .tooltip-arrow {
  bottom: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 5px 5px 0;
  border-top-color: #000; }

.tooltip.top-left .tooltip-arrow {
  bottom: 0;
  left: 5px;
  border-width: 5px 5px 0;
  border-top-color: #000; }

.tooltip.top-right .tooltip-arrow {
  bottom: 0;
  right: 5px;
  border-width: 5px 5px 0;
  border-top-color: #000; }

.tooltip.right .tooltip-arrow {
  top: 50%;
  left: 0;
  margin-top: -5px;
  border-width: 5px 5px 5px 0;
  border-right-color: #000; }

.tooltip.left .tooltip-arrow {
  top: 50%;
  right: 0;
  margin-top: -5px;
  border-width: 5px 0 5px 5px;
  border-left-color: #000; }

.tooltip.bottom .tooltip-arrow {
  top: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000; }

.tooltip.bottom-left .tooltip-arrow {
  top: 0;
  left: 5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000; }

.tooltip.bottom-right .tooltip-arrow {
  top: 0;
  right: 5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000; }

.popover {
  position: absolute;
  top: 0;
  left: 0;
  z-index: 1010;
  display: none;
  max-width: 276px;
  padding: 1px;
  text-align: left;
  background-color: #fff;
  background-clip: padding-box;
  border: 1px solid #ccc;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 6px;
  -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  white-space: normal; }

.popover.top {
  margin-top: -10px; }

.popover.right {
  margin-left: 10px; }

.popover.bottom {
  margin-top: 10px; }

.popover.left {
  margin-left: -10px; }

.popover-title {
  margin: 0;
  padding: 8px 14px;
  font-size: 14px;
  font-weight: 400;
  line-height: 18px;
  background-color: #f7f7f7;
  border-bottom: 1px solid #ebebeb;
  border-radius: 5px 5px 0 0; }

.popover-content {
  padding: 9px 14px; }

.popover > .arrow, .popover > .arrow:after {
  position: absolute;
  display: block;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid; }

.popover > .arrow {
  border-width: 11px; }

.popover > .arrow:after {
  border-width: 10px;
  content: ""; }

.popover.top > .arrow {
  left: 50%;
  margin-left: -11px;
  border-bottom-width: 0;
  border-top-color: #999;
  border-top-color: rgba(0, 0, 0, 0.25);
  bottom: -11px; }

.popover.top > .arrow:after {
  content: " ";
  bottom: 1px;
  margin-left: -10px;
  border-bottom-width: 0;
  border-top-color: #fff; }

.popover.right > .arrow {
  top: 50%;
  left: -11px;
  margin-top: -11px;
  border-left-width: 0;
  border-right-color: #999;
  border-right-color: rgba(0, 0, 0, 0.25); }

.popover.right > .arrow:after {
  content: " ";
  left: 1px;
  bottom: -10px;
  border-left-width: 0;
  border-right-color: #fff; }

.popover.bottom > .arrow {
  left: 50%;
  margin-left: -11px;
  border-top-width: 0;
  border-bottom-color: #999;
  border-bottom-color: rgba(0, 0, 0, 0.25);
  top: -11px; }

.popover.bottom > .arrow:after {
  content: " ";
  top: 1px;
  margin-left: -10px;
  border-top-width: 0;
  border-bottom-color: #fff; }

.popover.left > .arrow {
  top: 50%;
  right: -11px;
  margin-top: -11px;
  border-right-width: 0;
  border-left-color: #999;
  border-left-color: rgba(0, 0, 0, 0.25); }

.popover.left > .arrow:after {
  content: " ";
  right: 1px;
  border-right-width: 0;
  border-left-color: #fff;
  bottom: -10px; }

.carousel-inner > .item {
  display: none;
  position: relative;
  -webkit-transition: .6s ease-in-out left;
  transition: .6s ease-in-out left; }

.carousel-inner > .item > img, .carousel-inner > .item > a > img {
  line-height: 1; }

.carousel-inner > .active {
  left: 0; }

.carousel-inner > .next, .carousel-inner > .prev {
  position: absolute;
  top: 0;
  width: 100%; }

.carousel-inner > .next {
  left: 100%; }

.carousel-inner > .prev {
  left: -100%; }

.carousel-inner > .next.left, .carousel-inner > .prev.right {
  left: 0; }

.carousel-inner > .active.left {
  left: -100%; }

.carousel-inner > .active.right {
  left: 100%; }

.carousel-control {
  position: absolute;
  top: 0;
  left: 0;
  bottom: 0;
  width: 15%;
  opacity: .5;
  filter: alpha(opacity=50);
  font-size: 20px;
  color: #fff;
  text-align: center;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6); }

.carousel-control.left {
  background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.5) 0), color-stop(rgba(0, 0, 0, 0.0001) 100%));
  background-image: linear-gradient(to right, rgba(0, 0, 0, 0.5) 0, rgba(0, 0, 0, 0.0001) 100%);
  background-repeat: repeat-x;
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#80000000', endColorstr='#00000000', GradientType=1); }

.carousel-control.right {
  left: auto;
  right: 0;
  background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.0001) 0), color-stop(rgba(0, 0, 0, 0.5) 100%));
  background-image: linear-gradient(to right, rgba(0, 0, 0, 0.0001) 0, rgba(0, 0, 0, 0.5) 100%);
  background-repeat: repeat-x;
  filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#80000000', GradientType=1); }

.carousel-control:hover, .carousel-control:focus {
  outline: 0;
  color: #fff;
  text-decoration: none;
  opacity: .9;
  filter: alpha(opacity=90); }

.carousel-control .icon-prev, .carousel-control .icon-next, .carousel-control .glyphicon-chevron-left, .carousel-control .glyphicon-chevron-right {
  position: absolute;
  top: 50%;
  z-index: 5;
  display: inline-block; }

.carousel-control .icon-prev, .carousel-control .glyphicon-chevron-left {
  left: 50%; }

.carousel-control .icon-next, .carousel-control .glyphicon-chevron-right {
  right: 50%; }

.carousel-control .icon-prev, .carousel-control .icon-next {
  width: 20px;
  height: 20px;
  margin-top: -10px;
  margin-left: -10px;
  font-family: serif; }

.carousel-control .icon-prev:before {
  content: '\2039'; }

.carousel-control .icon-next:before {
  content: '\203a'; }

.carousel-indicators li {
  display: inline-block;
  width: 10px;
  height: 10px;
  margin: 1px;
  text-indent: -999px;
  border: 1px solid #fff;
  border-radius: 10px;
  cursor: pointer;
  background-color: #000 \9;
  background-color: transparent; }

.carousel-indicators .active {
  margin: 0;
  width: 12px;
  height: 12px;
  background-color: #fff; }

.carousel-caption {
  color: #fff;
  left: 15%;
  padding-bottom: 20px;
  position: absolute;
  right: 15%;
  text-align: center;
  top: 26%;
  z-index: 10; }

.carousel-caption .btn {
  text-shadow: none; }

@media screen and (min-width: 768px) {
  .carousel-control .glyphicon-chevron-left, .carousel-control .glyphicon-chevron-right, .carousel-control .icon-prev, .carousel-control .icon-next {
    width: 30px;
    height: 30px;
    margin-top: -15px;
    margin-left: -15px;
    font-size: 30px; }

  .carousel-caption {
    left: 20%;
    right: 20%;
    padding-bottom: 30px; }

  .carousel-indicators {
    bottom: 20px; } }
.clearfix:before, .clearfix:after, .container:before, .container:after, .container-fluid:before, .container-fluid:after, .row:before, .row:after, .form-horizontal .form-group:before, .form-horizontal .form-group:after, .btn-toolbar:before, .btn-toolbar:after, .btn-group-vertical > .btn-group:before, .btn-group-vertical > .btn-group:after, .nav:before, .nav:after, .navbar:before, .navbar:after, .navbar-header:before, .navbar-header:after, .navbar-collapse:before, .navbar-collapse:after, .pager:before, .pager:after, .panel-body:before, .panel-body:after, .modal-footer:before, .modal-footer:after {
  content: " ";
  display: table; }

.clearfix:after, .container:after, .container-fluid:after, .row:after, .form-horizontal .form-group:after, .btn-toolbar:after, .btn-group-vertical > .btn-group:after, .nav:after, .navbar:after, .navbar-header:after, .navbar-collapse:after, .pager:after, .panel-body:after, .modal-footer:after {
  clear: both; }

.center-block {
  display: block;
  margin-left: auto;
  margin-right: auto; }

.pull-right {
  float: right !important; }

.pull-left {
  float: left !important; }

.hide {
  display: none !important; }

.show {
  display: block !important; }

.invisible {
  visibility: hidden; }

.text-hide {
  font: 0/0 a;
  color: transparent;
  text-shadow: none;
  background-color: transparent;
  border: 0; }

.hidden {
  display: none !important;
  visibility: hidden !important; }

.affix {
  position: fixed; }

@-ms-viewport {
  width: device-width; }
.visible-xs, .visible-sm, .visible-md, .visible-lg {
  display: none !important; }

@media (max-width: 767px) {
  .visible-xs {
    display: block !important; }

  table.visible-xs {
    display: table; }

  tr.visible-xs {
    display: table-row !important; }

  th.visible-xs, td.visible-xs {
    display: table-cell !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm {
    display: block !important; }

  table.visible-sm {
    display: table; }

  tr.visible-sm {
    display: table-row !important; }

  th.visible-sm, td.visible-sm {
    display: table-cell !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md {
    display: block !important; }

  table.visible-md {
    display: table; }

  tr.visible-md {
    display: table-row !important; }

  th.visible-md, td.visible-md {
    display: table-cell !important; } }
@media (min-width: 1200px) {
  .visible-lg {
    display: block !important; }

  table.visible-lg {
    display: table; }

  tr.visible-lg {
    display: table-row !important; }

  th.visible-lg, td.visible-lg {
    display: table-cell !important; } }
@media (max-width: 767px) {
  .hidden-xs {
    display: none !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .hidden-sm {
    display: none !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-md {
    display: none !important; } }
@media (min-width: 1200px) {
  .hidden-lg {
    display: none !important; } }
.visible-print {
  display: none !important; }

@media print {
  .visible-print {
    display: block !important; }

  table.visible-print {
    display: table; }

  tr.visible-print {
    display: table-row !important; }

  th.visible-print, td.visible-print {
    display: table-cell !important; } }
@media print {
  .hidden-print {
    display: none !important; } }
/*!
 * Bootstrap v3.1.1 (http://getbootstrap.com)
 * Copyright 2011-2014 Twitter, Inc.
 * Licensed under MIT (https://github.com/twbs/bootstrap/blob/master/LICENSE)
 */
@media print {
  * {
    text-shadow: none !important;
    color: #000 !important;
    background: transparent !important;
    box-shadow: none !important; }

  a, a:visited {
    text-decoration: underline; }

  a[href]:after {
    content: " (" attr(href) ")"; }

  abbr[title]:after {
    content: " (" attr(title) ")"; }

  a[href^="javascript:"]:after,
  a[href^="#"]:after {
    content: ""; }

  pre,
  blockquote {
    border: 1px solid #999;
    page-break-inside: avoid; }

  thead {
    display: table-header-group; }

  tr, img {
    page-break-inside: avoid; }

  img {
    max-width: 100% !important; }

  p, h2, h3 {
    orphans: 3;
    widows: 3; }

  h2, h3 {
    page-break-after: avoid; }

  select {
    background: #fff !important; }

  .navbar {
    display: none; }

  .table td,
  .table th {
    background-color: #fff !important; }

  .btn > .caret,
  .dropup > .btn > .caret {
    border-top-color: #000 !important; }

  .label {
    border: 1px solid #000; }

  .table {
    border-collapse: collapse !important; }

  .table-bordered th,
  .table-bordered td {
    border: 1px solid #ddd !important; } }
* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

:before,
:after {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

html {
  font-size: 62.5%;
  -webkit-tap-highlight-color: transparent; }

body {
  background-color: #fff;
  color: #333;
  font-family: "Helvetica Neue",Helvetica,Arial,sans-serif;
  font-size: 14px;
  line-height: 1.42857;
  overflow-x: hidden; }

input, button, select, textarea {
  font-family: inherit;
  font-size: inherit;
  line-height: inherit; }

a {
  color: #428bca;
  text-decoration: none; }

figure {
  margin: 0; }

img {
  vertical-align: middle; }

.img-responsive,
.thumbnail > img,
.thumbnail a > img,
.carousel-inner > .item > img,
.carousel-inner > .item > a > img {
  display: block;
  max-width: 100%;
  height: auto; }

.img-rounded {
  border-radius: 6px; }

.img-thumbnail {
  padding: 4px;
  line-height: 1.42857143;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  -webkit-transition: all .2s ease-in-out;
  transition: all .2s ease-in-out;
  display: inline-block;
  max-width: 100%;
  height: auto; }

.img-circle {
  border-radius: 50%; }

hr {
  margin-top: 20px;
  margin-bottom: 20px;
  border: 0;
  border-top: 1px solid #eee; }

.sr-only {
  position: absolute;
  width: 1px;
  height: 1px;
  margin: -1px;
  padding: 0;
  overflow: hidden;
  clip: rect(0, 0, 0, 0);
  border: 0; }

h1, h2, h3, h4, h5, h6, .h1, .h2, .h3, .h4, .h5, .h6 {
  font-family: inherit;
  font-weight: 500;
  line-height: 1.1;
  color: inherit; }

h1 small, h2 small, h3 small, h4 small, h5 small, h6 small, .h1 small, .h2 small, .h3 small, .h4 small, .h5 small, .h6 small, h1 .small, h2 .small, h3 .small, h4 .small, h5 .small, h6 .small, .h1 .small, .h2 .small, .h3 .small, .h4 .small, .h5 .small, .h6 .small {
  font-weight: 400;
  line-height: 1;
  color: #999; }

h1, .h1, h2, .h2, h3, .h3 {
  margin-top: 20px;
  margin-bottom: 10px; }

h1 small, .h1 small, h2 small, .h2 small, h3 small, .h3 small, h1 .small, .h1 .small, h2 .small, .h2 .small, h3 .small, .h3 .small {
  font-size: 65%; }

h4, .h4, h5, .h5, h6, .h6 {
  margin-top: 10px;
  margin-bottom: 10px; }

h4 small, .h4 small, h5 small, .h5 small, h6 small, .h6 small, h4 .small, .h4 .small, h5 .small, .h5 .small, h6 .small, .h6 .small {
  font-size: 75%; }

h1, .h1 {
  font-size: 36px; }

h2, .h2 {
  font-size: 30px; }

h3, .h3 {
  font-size: 24px; }

h4, .h4 {
  font-size: 18px; }

h5, .h5 {
  font-size: 14px; }

h6, .h6 {
  font-size: 12px; }

p {
  margin: 0 0 10px; }

.lead {
  margin-bottom: 20px;
  font-size: 16px;
  font-weight: 200;
  line-height: 1.4; }

@media (min-width: 768px) {
  .lead {
    font-size: 21px; } }
small, .small {
  font-size: 85%; }

cite {
  font-style: normal; }

.text-left {
  text-align: left; }

.text-right {
  text-align: right; }

.text-center {
  text-align: center; }

.text-justify {
  text-align: justify; }

.text-muted {
  color: #999; }

.text-primary {
  color: #428bca; }

a.text-primary:hover {
  color: #3071a9; }

.text-success {
  color: #3c763d; }

a.text-success:hover {
  color: #2b542c; }

.text-info {
  color: #31708f; }

a.text-info:hover {
  color: #245269; }

.text-warning {
  color: #8a6d3b; }

a.text-warning:hover {
  color: #66512c; }

.text-danger {
  color: #a94442; }

a.text-danger:hover {
  color: #843534; }

.bg-primary {
  color: #fff;
  background-color: #428bca; }

a.bg-primary:hover {
  background-color: #3071a9; }

.bg-success {
  background-color: #dff0d8; }

a.bg-success:hover {
  background-color: #c1e2b3; }

.bg-info {
  background-color: #d9edf7; }

a.bg-info:hover {
  background-color: #afd9ee; }

.bg-warning {
  background-color: #fcf8e3; }

a.bg-warning:hover {
  background-color: #f7ecb5; }

.bg-danger {
  background-color: #f2dede; }

a.bg-danger:hover {
  background-color: #e4b9b9; }

.page-header {
  padding-bottom: 9px;
  margin: 40px 0 20px;
  border-bottom: 1px solid #eee; }

ul, ol {
  margin-top: 0;
  margin-bottom: 10px; }

ul ul, ol ul, ul ol, ol ol {
  margin-bottom: 0; }

.list-unstyled {
  padding-left: 0;
  list-style: none; }

.list-inline {
  padding-left: 0;
  list-style: none;
  margin-left: -5px; }

.list-inline > li {
  display: inline-block;
  padding-left: 5px;
  padding-right: 5px; }

dl {
  margin-top: 0;
  margin-bottom: 20px; }

dt, dd {
  line-height: 1.42857143; }

dt {
  font-weight: 700; }

dd {
  margin-left: 0; }

@media (min-width: 768px) {
  .dl-horizontal dt {
    float: left;
    width: 160px;
    clear: left;
    text-align: right;
    overflow: hidden;
    text-overflow: ellipsis;
    white-space: nowrap; }

  .dl-horizontal dd {
    margin-left: 180px; } }
abbr[title], abbr[data-original-title] {
  cursor: help;
  border-bottom: 1px dotted #999; }

.initialism {
  font-size: 90%;
  text-transform: uppercase; }

blockquote {
  padding: 10px 20px;
  margin: 0 0 20px;
  font-size: 17.5px;
  border-left: 5px solid #eee; }

blockquote p:last-child, blockquote ul:last-child, blockquote ol:last-child {
  margin-bottom: 0; }

blockquote footer, blockquote small, blockquote .small {
  display: block;
  font-size: 80%;
  line-height: 1.42857143;
  color: #999; }

blockquote footer:before, blockquote small:before, blockquote .small:before {
  content: '\2014 \00A0'; }

.blockquote-reverse, blockquote.pull-right {
  padding-right: 15px;
  padding-left: 0;
  border-right: 5px solid #eee;
  border-left: 0;
  text-align: right; }

.blockquote-reverse footer:before, blockquote.pull-right footer:before, .blockquote-reverse small:before, blockquote.pull-right small:before, .blockquote-reverse .small:before, blockquote.pull-right .small:before {
  content: ''; }

.blockquote-reverse footer:after, blockquote.pull-right footer:after, .blockquote-reverse small:after, blockquote.pull-right small:after, .blockquote-reverse .small:after, blockquote.pull-right .small:after {
  content: '\00A0 \2014'; }

blockquote:before, blockquote:after {
  content: ""; }

address {
  margin-bottom: 20px;
  font-style: normal;
  line-height: 1.42857143; }

code, kbd, pre, samp {
  font-family: Menlo,Monaco,Consolas,"Courier New",monospace; }

code {
  padding: 2px 4px;
  font-size: 90%;
  color: #c7254e;
  background-color: #f9f2f4;
  white-space: nowrap;
  border-radius: 4px; }

kbd {
  padding: 2px 4px;
  font-size: 90%;
  color: #fff;
  background-color: #333;
  border-radius: 3px;
  box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.25); }

pre {
  display: block;
  padding: 9.5px;
  margin: 0 0 10px;
  font-size: 13px;
  line-height: 1.42857143;
  word-break: break-all;
  word-wrap: break-word;
  color: #333;
  background-color: #f5f5f5;
  border: 1px solid #ccc;
  border-radius: 4px; }

pre code {
  padding: 0;
  font-size: inherit;
  color: inherit;
  white-space: pre-wrap;
  background-color: transparent;
  border-radius: 0; }

.pre-scrollable {
  max-height: 340px;
  overflow-y: scroll; }

/*  Increased container to width 100% for design*/
.container {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px;
  width: 100%; }

@media (min-width: 768px) {
  .container {
    width: 100%; } }
@media (min-width: 992px) {
  .container {
    width: 100%; } }
@media (min-width: 1200px) {
  .container {
    width: 100%; } }
.container-fluid {
  margin-right: auto;
  margin-left: auto;
  padding-left: 15px;
  padding-right: 15px; }

.row {
  margin-left: -15px;
  margin-right: -15px; }

.col-xs-1, .col-sm-1, .col-md-1, .col-lg-1, .col-xs-2, .col-sm-2, .col-md-2, .col-lg-2, .col-xs-3, .col-sm-3, .col-md-3, .col-lg-3, .col-xs-4, .col-sm-4, .col-md-4, .col-lg-4, .col-xs-5, .col-sm-5, .col-md-5, .col-lg-5, .col-xs-6, .col-sm-6, .col-md-6, .col-lg-6, .col-xs-7, .col-sm-7, .col-md-7, .col-lg-7, .col-xs-8, .col-sm-8, .col-md-8, .col-lg-8, .col-xs-9, .col-sm-9, .col-md-9, .col-lg-9, .col-xs-10, .col-sm-10, .col-md-10, .col-lg-10, .col-xs-11, .col-sm-11, .col-md-11, .col-lg-11, .col-xs-12, .col-sm-12, .col-md-12, .col-lg-12 {
  position: relative;
  min-height: 1px;
  padding-left: 15px;
  padding-right: 15px; }

.col-xs-1, .col-xs-2, .col-xs-3, .col-xs-4, .col-xs-5, .col-xs-6, .col-xs-7, .col-xs-8, .col-xs-9, .col-xs-10, .col-xs-11, .col-xs-12 {
  float: left; }

.col-xs-12 {
  width: 100%; }

.col-xs-11 {
  width: 91.66666667%; }

.col-xs-10 {
  width: 83.33333333%; }

.col-xs-9 {
  width: 75%; }

.col-xs-8 {
  width: 66.66666667%; }

.col-xs-7 {
  width: 58.33333333%; }

.col-xs-6 {
  width: 50%; }

.col-xs-5 {
  width: 41.66666667%; }

.col-xs-4 {
  width: 33.33333333%; }

.col-xs-3 {
  width: 25%; }

.col-xs-2 {
  width: 16.66666667%; }

.col-xs-1 {
  width: 8.33333333%; }

.col-xs-pull-12 {
  right: 100%; }

.col-xs-pull-11 {
  right: 91.66666667%; }

.col-xs-pull-10 {
  right: 83.33333333%; }

.col-xs-pull-9 {
  right: 75%; }

.col-xs-pull-8 {
  right: 66.66666667%; }

.col-xs-pull-7 {
  right: 58.33333333%; }

.col-xs-pull-6 {
  right: 50%; }

.col-xs-pull-5 {
  right: 41.66666667%; }

.col-xs-pull-4 {
  right: 33.33333333%; }

.col-xs-pull-3 {
  right: 25%; }

.col-xs-pull-2 {
  right: 16.66666667%; }

.col-xs-pull-1 {
  right: 8.33333333%; }

.col-xs-pull-0 {
  right: 0; }

.col-xs-push-12 {
  left: 100%; }

.col-xs-push-11 {
  left: 91.66666667%; }

.col-xs-push-10 {
  left: 83.33333333%; }

.col-xs-push-9 {
  left: 75%; }

.col-xs-push-8 {
  left: 66.66666667%; }

.col-xs-push-7 {
  left: 58.33333333%; }

.col-xs-push-6 {
  left: 50%; }

.col-xs-push-5 {
  left: 41.66666667%; }

.col-xs-push-4 {
  left: 33.33333333%; }

.col-xs-push-3 {
  left: 25%; }

.col-xs-push-2 {
  left: 16.66666667%; }

.col-xs-push-1 {
  left: 8.33333333%; }

.col-xs-push-0 {
  left: 0; }

.col-xs-offset-12 {
  margin-left: 100%; }

.col-xs-offset-11 {
  margin-left: 91.66666667%; }

.col-xs-offset-10 {
  margin-left: 83.33333333%; }

.col-xs-offset-9 {
  margin-left: 75%; }

.col-xs-offset-8 {
  margin-left: 66.66666667%; }

.col-xs-offset-7 {
  margin-left: 58.33333333%; }

.col-xs-offset-6 {
  margin-left: 50%; }

.col-xs-offset-5 {
  margin-left: 41.66666667%; }

.col-xs-offset-4 {
  margin-left: 33.33333333%; }

.col-xs-offset-3 {
  margin-left: 25%; }

.col-xs-offset-2 {
  margin-left: 16.66666667%; }

.col-xs-offset-1 {
  margin-left: 8.33333333%; }

.col-xs-offset-0 {
  margin-left: 0; }

@media (min-width: 768px) {
  .col-sm-1, .col-sm-2, .col-sm-3, .col-sm-4, .col-sm-5, .col-sm-6, .col-sm-7, .col-sm-8, .col-sm-9, .col-sm-10, .col-sm-11, .col-sm-12 {
    float: left; }

  .col-sm-12 {
    width: 100%; }

  .col-sm-11 {
    width: 91.66666667%; }

  .col-sm-10 {
    width: 83.33333333%; }

  .col-sm-9 {
    width: 75%; }

  .col-sm-8 {
    width: 66.66666667%; }

  .col-sm-7 {
    width: 58.33333333%; }

  .col-sm-6 {
    width: 50%; }

  .col-sm-5 {
    width: 41.66666667%; }

  .col-sm-4 {
    width: 33.33333333%; }

  .col-sm-3 {
    width: 25%; }

  .col-sm-2 {
    width: 16.66666667%; }

  .col-sm-1 {
    width: 8.33333333%; }

  .col-sm-pull-12 {
    right: 100%; }

  .col-sm-pull-11 {
    right: 91.66666667%; }

  .col-sm-pull-10 {
    right: 83.33333333%; }

  .col-sm-pull-9 {
    right: 75%; }

  .col-sm-pull-8 {
    right: 66.66666667%; }

  .col-sm-pull-7 {
    right: 58.33333333%; }

  .col-sm-pull-6 {
    right: 50%; }

  .col-sm-pull-5 {
    right: 41.66666667%; }

  .col-sm-pull-4 {
    right: 33.33333333%; }

  .col-sm-pull-3 {
    right: 25%; }

  .col-sm-pull-2 {
    right: 16.66666667%; }

  .col-sm-pull-1 {
    right: 8.33333333%; }

  .col-sm-pull-0 {
    right: 0; }

  .col-sm-push-12 {
    left: 100%; }

  .col-sm-push-11 {
    left: 91.66666667%; }

  .col-sm-push-10 {
    left: 83.33333333%; }

  .col-sm-push-9 {
    left: 75%; }

  .col-sm-push-8 {
    left: 66.66666667%; }

  .col-sm-push-7 {
    left: 58.33333333%; }

  .col-sm-push-6 {
    left: 50%; }

  .col-sm-push-5 {
    left: 41.66666667%; }

  .col-sm-push-4 {
    left: 33.33333333%; }

  .col-sm-push-3 {
    left: 25%; }

  .col-sm-push-2 {
    left: 16.66666667%; }

  .col-sm-push-1 {
    left: 8.33333333%; }

  .col-sm-push-0 {
    left: 0; }

  .col-sm-offset-12 {
    margin-left: 100%; }

  .col-sm-offset-11 {
    margin-left: 91.66666667%; }

  .col-sm-offset-10 {
    margin-left: 83.33333333%; }

  .col-sm-offset-9 {
    margin-left: 75%; }

  .col-sm-offset-8 {
    margin-left: 66.66666667%; }

  .col-sm-offset-7 {
    margin-left: 58.33333333%; }

  .col-sm-offset-6 {
    margin-left: 50%; }

  .col-sm-offset-5 {
    margin-left: 41.66666667%; }

  .col-sm-offset-4 {
    margin-left: 33.33333333%; }

  .col-sm-offset-3 {
    margin-left: 25%; }

  .col-sm-offset-2 {
    margin-left: 16.66666667%; }

  .col-sm-offset-1 {
    margin-left: 8.33333333%; }

  .col-sm-offset-0 {
    margin-left: 0; } }
@media (min-width: 992px) {
  .col-md-1, .col-md-2, .col-md-3, .col-md-4, .col-md-5, .col-md-6, .col-md-7, .col-md-8, .col-md-9, .col-md-10, .col-md-11, .col-md-12 {
    float: left; }

  .col-md-12 {
    width: 100%; }

  .col-md-11 {
    width: 91.66666667%; }

  .col-md-10 {
    width: 83.33333333%; }

  .col-md-9 {
    width: 75%; }

  .col-md-8 {
    width: 66.66666667%; }

  .col-md-7 {
    width: 58.33333333%; }

  .col-md-6 {
    width: 50%; }

  .col-md-5 {
    width: 41.66666667%; }

  .col-md-4 {
    width: 33.33333333%; }

  .col-md-3 {
    width: 25%; }

  .col-md-2 {
    width: 16.66666667%; }

  .col-md-1 {
    width: 8.33333333%; }

  .col-md-pull-12 {
    right: 100%; }

  .col-md-pull-11 {
    right: 91.66666667%; }

  .col-md-pull-10 {
    right: 83.33333333%; }

  .col-md-pull-9 {
    right: 75%; }

  .col-md-pull-8 {
    right: 66.66666667%; }

  .col-md-pull-7 {
    right: 58.33333333%; }

  .col-md-pull-6 {
    right: 50%; }

  .col-md-pull-5 {
    right: 41.66666667%; }

  .col-md-pull-4 {
    right: 33.33333333%; }

  .col-md-pull-3 {
    right: 25%; }

  .col-md-pull-2 {
    right: 16.66666667%; }

  .col-md-pull-1 {
    right: 8.33333333%; }

  .col-md-pull-0 {
    right: 0; }

  .col-md-push-12 {
    left: 100%; }

  .col-md-push-11 {
    left: 91.66666667%; }

  .col-md-push-10 {
    left: 83.33333333%; }

  .col-md-push-9 {
    left: 75%; }

  .col-md-push-8 {
    left: 66.66666667%; }

  .col-md-push-7 {
    left: 58.33333333%; }

  .col-md-push-6 {
    left: 50%; }

  .col-md-push-5 {
    left: 41.66666667%; }

  .col-md-push-4 {
    left: 33.33333333%; }

  .col-md-push-3 {
    left: 25%; }

  .col-md-push-2 {
    left: 16.66666667%; }

  .col-md-push-1 {
    left: 8.33333333%; }

  .col-md-push-0 {
    left: 0; }

  .col-md-offset-12 {
    margin-left: 100%; }

  .col-md-offset-11 {
    margin-left: 91.66666667%; }

  .col-md-offset-10 {
    margin-left: 83.33333333%; }

  .col-md-offset-9 {
    margin-left: 75%; }

  .col-md-offset-8 {
    margin-left: 66.66666667%; }

  .col-md-offset-7 {
    margin-left: 58.33333333%; }

  .col-md-offset-6 {
    margin-left: 50%; }

  .col-md-offset-5 {
    margin-left: 41.66666667%; }

  .col-md-offset-4 {
    margin-left: 33.33333333%; }

  .col-md-offset-3 {
    margin-left: 25%; }

  .col-md-offset-2 {
    margin-left: 16.66666667%; }

  .col-md-offset-1 {
    margin-left: 8.33333333%; }

  .col-md-offset-0 {
    margin-left: 0; } }
@media (min-width: 1200px) {
  .col-lg-1, .col-lg-2, .col-lg-3, .col-lg-4, .col-lg-5, .col-lg-6, .col-lg-7, .col-lg-8, .col-lg-9, .col-lg-10, .col-lg-11, .col-lg-12 {
    float: left; }

  .col-lg-12 {
    width: 100%; }

  .col-lg-11 {
    width: 91.66666667%; }

  .col-lg-10 {
    width: 83.33333333%; }

  .col-lg-9 {
    width: 75%; }

  .col-lg-8 {
    width: 66.66666667%; }

  .col-lg-7 {
    width: 58.33333333%; }

  .col-lg-6 {
    width: 50%; }

  .col-lg-5 {
    width: 41.66666667%; }

  .col-lg-4 {
    width: 33.33333333%; }

  .col-lg-3 {
    width: 25%; }

  .col-lg-2 {
    width: 16.66666667%; }

  .col-lg-1 {
    width: 8.33333333%; }

  .col-lg-pull-12 {
    right: 100%; }

  .col-lg-pull-11 {
    right: 91.66666667%; }

  .col-lg-pull-10 {
    right: 83.33333333%; }

  .col-lg-pull-9 {
    right: 75%; }

  .col-lg-pull-8 {
    right: 66.66666667%; }

  .col-lg-pull-7 {
    right: 58.33333333%; }

  .col-lg-pull-6 {
    right: 50%; }

  .col-lg-pull-5 {
    right: 41.66666667%; }

  .col-lg-pull-4 {
    right: 33.33333333%; }

  .col-lg-pull-3 {
    right: 25%; }

  .col-lg-pull-2 {
    right: 16.66666667%; }

  .col-lg-pull-1 {
    right: 8.33333333%; }

  .col-lg-pull-0 {
    right: 0; }

  .col-lg-push-12 {
    left: 100%; }

  .col-lg-push-11 {
    left: 91.66666667%; }

  .col-lg-push-10 {
    left: 83.33333333%; }

  .col-lg-push-9 {
    left: 75%; }

  .col-lg-push-8 {
    left: 66.66666667%; }

  .col-lg-push-7 {
    left: 58.33333333%; }

  .col-lg-push-6 {
    left: 50%; }

  .col-lg-push-5 {
    left: 41.66666667%; }

  .col-lg-push-4 {
    left: 33.33333333%; }

  .col-lg-push-3 {
    left: 25%; }

  .col-lg-push-2 {
    left: 16.66666667%; }

  .col-lg-push-1 {
    left: 8.33333333%; }

  .col-lg-push-0 {
    left: 0; }

  .col-lg-offset-12 {
    margin-left: 100%; }

  .col-lg-offset-11 {
    margin-left: 91.66666667%; }

  .col-lg-offset-10 {
    margin-left: 83.33333333%; }

  .col-lg-offset-9 {
    margin-left: 75%; }

  .col-lg-offset-8 {
    margin-left: 66.66666667%; }

  .col-lg-offset-7 {
    margin-left: 58.33333333%; }

  .col-lg-offset-6 {
    margin-left: 50%; }

  .col-lg-offset-5 {
    margin-left: 41.66666667%; }

  .col-lg-offset-4 {
    margin-left: 33.33333333%; }

  .col-lg-offset-3 {
    margin-left: 25%; }

  .col-lg-offset-2 {
    margin-left: 16.66666667%; }

  .col-lg-offset-1 {
    margin-left: 8.33333333%; }

  .col-lg-offset-0 {
    margin-left: 0; } }
table {
  max-width: 100%;
  background-color: transparent; }

th {
  text-align: left; }

.table {
  width: 100%;
  margin-bottom: 20px; }

.table > thead > tr > th, .table > tbody > tr > th, .table > tfoot > tr > th, .table > thead > tr > td, .table > tbody > tr > td, .table > tfoot > tr > td {
  padding: 8px;
  line-height: 1.42857143;
  vertical-align: top;
  border-top: 1px solid #ddd; }

.table > thead > tr > th {
  vertical-align: bottom;
  border-bottom: 2px solid #ddd; }

.table > caption + thead > tr:first-child > th, .table > colgroup + thead > tr:first-child > th, .table > thead:first-child > tr:first-child > th, .table > caption + thead > tr:first-child > td, .table > colgroup + thead > tr:first-child > td, .table > thead:first-child > tr:first-child > td {
  border-top: 0; }

.table > tbody + tbody {
  border-top: 2px solid #ddd; }

.table .table {
  background-color: #fff; }

.table-condensed > thead > tr > th, .table-condensed > tbody > tr > th, .table-condensed > tfoot > tr > th, .table-condensed > thead > tr > td, .table-condensed > tbody > tr > td, .table-condensed > tfoot > tr > td {
  padding: 5px; }

.table-bordered {
  border: 1px solid #ddd; }

.table-bordered > thead > tr > th, .table-bordered > tbody > tr > th, .table-bordered > tfoot > tr > th, .table-bordered > thead > tr > td, .table-bordered > tbody > tr > td, .table-bordered > tfoot > tr > td {
  border: 1px solid #ddd; }

.table-bordered > thead > tr > th, .table-bordered > thead > tr > td {
  border-bottom-width: 2px; }

.table-striped > tbody > tr:nth-child(odd) > td, .table-striped > tbody > tr:nth-child(odd) > th {
  background-color: #f9f9f9; }

.table-hover > tbody > tr:hover > td, .table-hover > tbody > tr:hover > th {
  background-color: #f5f5f5; }

table col[class*=col-] {
  position: static;
  float: none;
  display: table-column; }

table td[class*=col-], table th[class*=col-] {
  position: static;
  float: none;
  display: table-cell; }

.table > thead > tr > td.active, .table > tbody > tr > td.active, .table > tfoot > tr > td.active, .table > thead > tr > th.active, .table > tbody > tr > th.active, .table > tfoot > tr > th.active, .table > thead > tr.active > td, .table > tbody > tr.active > td, .table > tfoot > tr.active > td, .table > thead > tr.active > th, .table > tbody > tr.active > th, .table > tfoot > tr.active > th {
  background-color: #f5f5f5; }

.table-hover > tbody > tr > td.active:hover, .table-hover > tbody > tr > th.active:hover, .table-hover > tbody > tr.active:hover > td, .table-hover > tbody > tr.active:hover > th {
  background-color: #e8e8e8; }

.table > thead > tr > td.success, .table > tbody > tr > td.success, .table > tfoot > tr > td.success, .table > thead > tr > th.success, .table > tbody > tr > th.success, .table > tfoot > tr > th.success, .table > thead > tr.success > td, .table > tbody > tr.success > td, .table > tfoot > tr.success > td, .table > thead > tr.success > th, .table > tbody > tr.success > th, .table > tfoot > tr.success > th {
  background-color: #dff0d8; }

.table-hover > tbody > tr > td.success:hover, .table-hover > tbody > tr > th.success:hover, .table-hover > tbody > tr.success:hover > td, .table-hover > tbody > tr.success:hover > th {
  background-color: #d0e9c6; }

.table > thead > tr > td.info, .table > tbody > tr > td.info, .table > tfoot > tr > td.info, .table > thead > tr > th.info, .table > tbody > tr > th.info, .table > tfoot > tr > th.info, .table > thead > tr.info > td, .table > tbody > tr.info > td, .table > tfoot > tr.info > td, .table > thead > tr.info > th, .table > tbody > tr.info > th, .table > tfoot > tr.info > th {
  background-color: #d9edf7; }

.table-hover > tbody > tr > td.info:hover, .table-hover > tbody > tr > th.info:hover, .table-hover > tbody > tr.info:hover > td, .table-hover > tbody > tr.info:hover > th {
  background-color: #c4e3f3; }

.table > thead > tr > td.warning, .table > tbody > tr > td.warning, .table > tfoot > tr > td.warning, .table > thead > tr > th.warning, .table > tbody > tr > th.warning, .table > tfoot > tr > th.warning, .table > thead > tr.warning > td, .table > tbody > tr.warning > td, .table > tfoot > tr.warning > td, .table > thead > tr.warning > th, .table > tbody > tr.warning > th, .table > tfoot > tr.warning > th {
  background-color: #fcf8e3; }

.table-hover > tbody > tr > td.warning:hover, .table-hover > tbody > tr > th.warning:hover, .table-hover > tbody > tr.warning:hover > td, .table-hover > tbody > tr.warning:hover > th {
  background-color: #faf2cc; }

.table > thead > tr > td.danger, .table > tbody > tr > td.danger, .table > tfoot > tr > td.danger, .table > thead > tr > th.danger, .table > tbody > tr > th.danger, .table > tfoot > tr > th.danger, .table > thead > tr.danger > td, .table > tbody > tr.danger > td, .table > tfoot > tr.danger > td, .table > thead > tr.danger > th, .table > tbody > tr.danger > th, .table > tfoot > tr.danger > th {
  background-color: #f2dede; }

.table-hover > tbody > tr > td.danger:hover, .table-hover > tbody > tr > th.danger:hover, .table-hover > tbody > tr.danger:hover > td, .table-hover > tbody > tr.danger:hover > th {
  background-color: #ebcccc; }

@media (max-width: 767px) {
  .table-responsive {
    width: 100%;
    margin-bottom: 15px;
    overflow-y: hidden;
    overflow-x: scroll;
    -ms-overflow-style: -ms-autohiding-scrollbar;
    border: 1px solid #ddd;
    -webkit-overflow-scrolling: touch; }

  .table-responsive > .table {
    margin-bottom: 0; }

  .table-responsive > .table > thead > tr > th, .table-responsive > .table > tbody > tr > th, .table-responsive > .table > tfoot > tr > th, .table-responsive > .table > thead > tr > td, .table-responsive > .table > tbody > tr > td, .table-responsive > .table > tfoot > tr > td {
    white-space: nowrap; }

  .table-responsive > .table-bordered {
    border: 0; }

  .table-responsive > .table-bordered > thead > tr > th:first-child, .table-responsive > .table-bordered > tbody > tr > th:first-child, .table-responsive > .table-bordered > tfoot > tr > th:first-child, .table-responsive > .table-bordered > thead > tr > td:first-child, .table-responsive > .table-bordered > tbody > tr > td:first-child, .table-responsive > .table-bordered > tfoot > tr > td:first-child {
    border-left: 0; }

  .table-responsive > .table-bordered > thead > tr > th:last-child, .table-responsive > .table-bordered > tbody > tr > th:last-child, .table-responsive > .table-bordered > tfoot > tr > th:last-child, .table-responsive > .table-bordered > thead > tr > td:last-child, .table-responsive > .table-bordered > tbody > tr > td:last-child, .table-responsive > .table-bordered > tfoot > tr > td:last-child {
    border-right: 0; }

  .table-responsive > .table-bordered > tbody > tr:last-child > th, .table-responsive > .table-bordered > tfoot > tr:last-child > th, .table-responsive > .table-bordered > tbody > tr:last-child > td, .table-responsive > .table-bordered > tfoot > tr:last-child > td {
    border-bottom: 0; } }
fieldset {
  padding: 0;
  margin: 0;
  border: 0;
  min-width: 0; }

legend {
  display: block;
  width: 100%;
  padding: 0;
  margin-bottom: 20px;
  font-size: 21px;
  line-height: inherit;
  color: #333;
  border: 0;
  border-bottom: 1px solid #e5e5e5; }

label {
  display: inline-block;
  margin-bottom: 5px;
  font-weight: 700; }

input[type=search] {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box; }

input[type=radio], input[type=checkbox] {
  margin: 4px 0 0;
  margin-top: 1px \9;
  line-height: normal; }

input[type=file] {
  display: block; }

input[type=range] {
  display: block;
  width: 100%; }

select[multiple], select[size] {
  height: auto; }

input[type=file]:focus, input[type=radio]:focus, input[type=checkbox]:focus {
  outline: thin dotted;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px; }

output {
  display: block;
  padding-top: 7px;
  font-size: 14px;
  line-height: 1.42857143;
  color: #555; }

.form-control {
  display: block;
  width: 100%;
  height: 34px;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.42857143;
  color: #555;
  background-color: #fff;
  background-image: none;
  border: 1px solid #ccc;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  -webkit-transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s;
  transition: border-color ease-in-out .15s,box-shadow ease-in-out .15s; }

.form-control:focus {
  border-color: #66afe9;
  outline: 0;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 8px rgba(102, 175, 233, 0.6); }

.form-control::-moz-placeholder {
  color: #999;
  opacity: 1; }

.form-control:-ms-input-placeholder {
  color: #999; }

.form-control::-webkit-input-placeholder {
  color: #999; }

.form-control[disabled], .form-control[readonly], fieldset[disabled] .form-control {
  cursor: not-allowed;
  background-color: #eee;
  opacity: 1; }

textarea.form-control {
  height: auto; }

input[type=search] {
  -webkit-appearance: none; }

input[type=date] {
  line-height: 34px; }

.form-group {
  margin-bottom: 15px; }

.radio, .checkbox {
  display: block;
  min-height: 20px;
  margin-top: 10px;
  margin-bottom: 10px;
  padding-left: 20px; }

.radio label, .checkbox label {
  display: inline;
  font-weight: 400;
  cursor: pointer; }

.radio input[type=radio], .radio-inline input[type=radio], .checkbox input[type=checkbox], .checkbox-inline input[type=checkbox] {
  float: left;
  margin-left: -20px; }

.radio + .radio, .checkbox + .checkbox {
  margin-top: -5px; }

.radio-inline, .checkbox-inline {
  display: inline-block;
  padding-left: 20px;
  margin-bottom: 0;
  vertical-align: middle;
  font-weight: 400;
  cursor: pointer; }

.radio-inline + .radio-inline, .checkbox-inline + .checkbox-inline {
  margin-top: 0;
  margin-left: 10px; }

input[type=radio][disabled], input[type=checkbox][disabled], .radio[disabled], .radio-inline[disabled], .checkbox[disabled], .checkbox-inline[disabled], fieldset[disabled] input[type=radio], fieldset[disabled] input[type=checkbox], fieldset[disabled] .radio, fieldset[disabled] .radio-inline, fieldset[disabled] .checkbox, fieldset[disabled] .checkbox-inline {
  cursor: not-allowed; }

.input-sm {
  height: 30px;
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

select.input-sm {
  height: 30px;
  line-height: 30px; }

textarea.input-sm, select[multiple].input-sm {
  height: auto; }

.input-lg {
  height: 46px;
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

select.input-lg {
  height: 46px;
  line-height: 46px; }

textarea.input-lg, select[multiple].input-lg {
  height: auto; }

.has-feedback {
  position: relative; }

.has-feedback .form-control {
  padding-right: 42.5px; }

.has-feedback .form-control-feedback {
  position: absolute;
  top: 25px;
  right: 0;
  display: block;
  width: 34px;
  height: 34px;
  line-height: 34px;
  text-align: center; }

.has-success .help-block, .has-success .control-label, .has-success .radio, .has-success .checkbox, .has-success .radio-inline, .has-success .checkbox-inline {
  color: #3c763d; }

.has-success .form-control {
  border-color: #3c763d;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }

.has-success .form-control:focus {
  border-color: #2b542c;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #67b168; }

.has-success .input-group-addon {
  color: #3c763d;
  border-color: #3c763d;
  background-color: #dff0d8; }

.has-success .form-control-feedback {
  color: #3c763d; }

.has-warning .help-block, .has-warning .control-label, .has-warning .radio, .has-warning .checkbox, .has-warning .radio-inline, .has-warning .checkbox-inline {
  color: #8a6d3b; }

.has-warning .form-control {
  border-color: #8a6d3b;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }

.has-warning .form-control:focus {
  border-color: #66512c;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #c0a16b; }

.has-warning .input-group-addon {
  color: #8a6d3b;
  border-color: #8a6d3b;
  background-color: #fcf8e3; }

.has-warning .form-control-feedback {
  color: #8a6d3b; }

.has-error .help-block, .has-error .control-label, .has-error .radio, .has-error .checkbox, .has-error .radio-inline, .has-error .checkbox-inline {
  color: #a94442; }

.has-error .form-control {
  border-color: #a94442;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); }

.has-error .form-control:focus {
  border-color: #843534;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483;
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075), 0 0 6px #ce8483; }

.has-error .input-group-addon {
  color: #a94442;
  border-color: #a94442;
  background-color: #f2dede; }

.has-error .form-control-feedback {
  color: #a94442; }

.form-control-static {
  margin-bottom: 0; }

.help-block {
  display: block;
  margin-top: 5px;
  margin-bottom: 10px;
  color: #737373; }

@media (min-width: 768px) {
  .form-inline .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle; }

  .form-inline .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle; }

  .form-inline .input-group > .form-control {
    width: 100%; }

  .form-inline .control-label {
    margin-bottom: 0;
    vertical-align: middle; }

  .form-inline .radio, .form-inline .checkbox {
    display: inline-block;
    margin-top: 0;
    margin-bottom: 0;
    padding-left: 0;
    vertical-align: middle; }

  .form-inline .radio input[type=radio], .form-inline .checkbox input[type=checkbox] {
    float: none;
    margin-left: 0; }

  .form-inline .has-feedback .form-control-feedback {
    top: 0; } }
.form-horizontal .control-label, .form-horizontal .radio, .form-horizontal .checkbox, .form-horizontal .radio-inline, .form-horizontal .checkbox-inline {
  margin-top: 0;
  margin-bottom: 0;
  padding-top: 7px; }

.form-horizontal .radio, .form-horizontal .checkbox {
  min-height: 27px; }

.form-horizontal .form-group {
  margin-left: -15px;
  margin-right: -15px; }

.form-horizontal .form-control-static {
  padding-top: 7px; }

@media (min-width: 768px) {
  .form-horizontal .control-label {
    text-align: right; } }
.form-horizontal .has-feedback .form-control-feedback {
  top: 0;
  right: 15px; }

.btn {
  display: inline-block;
  margin-bottom: 0;
  font-weight: 400;
  text-align: center;
  vertical-align: middle;
  cursor: pointer;
  background-image: none;
  border: 1px solid transparent;
  white-space: nowrap;
  padding: 6px 12px;
  font-size: 14px;
  line-height: 1.42857143;
  border-radius: 4px;
  -webkit-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none; }

.btn:focus, .btn:active:focus, .btn.active:focus {
  outline: thin dotted;
  outline: 5px auto -webkit-focus-ring-color;
  outline-offset: -2px; }

.btn:hover, .btn:focus {
  color: #333;
  text-decoration: none; }

.btn:active, .btn.active {
  outline: 0;
  background-image: none;
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }

.btn.disabled, .btn[disabled], fieldset[disabled] .btn {
  cursor: not-allowed;
  pointer-events: none;
  opacity: .65;
  filter: alpha(opacity=65);
  -webkit-box-shadow: none;
  box-shadow: none; }

.btn-default {
  color: #333;
  background-color: #fff;
  border-color: #ccc; }

.btn-default:hover, .btn-default:focus, .btn-default:active, .btn-default.active, .open .dropdown-toggle.btn-default {
  color: #333;
  background-color: #ebebeb;
  border-color: #adadad; }

.btn-default:active, .btn-default.active, .open .dropdown-toggle.btn-default {
  background-image: none; }

.btn-default.disabled, .btn-default[disabled], fieldset[disabled] .btn-default, .btn-default.disabled:hover, .btn-default[disabled]:hover, fieldset[disabled] .btn-default:hover, .btn-default.disabled:focus, .btn-default[disabled]:focus, fieldset[disabled] .btn-default:focus, .btn-default.disabled:active, .btn-default[disabled]:active, fieldset[disabled] .btn-default:active, .btn-default.disabled.active, .btn-default[disabled].active, fieldset[disabled] .btn-default.active {
  background-color: #fff;
  border-color: #ccc; }

.btn-default .badge {
  color: #fff;
  background-color: #333; }

.btn-primary:hover, .btn-primary:focus, .btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary {
  color: #fff;
  background-color: #3276b1;
  border-color: #285e8e; }

.btn-primary:active, .btn-primary.active, .open .dropdown-toggle.btn-primary {
  background-image: none; }

.btn-primary.disabled,
.btn-primary[disabled],
fieldset[disabled] .btn-primary,
.btn-primary.disabled:hover,
.btn-primary[disabled]:hover,
fieldset[disabled] .btn-primary:hover,
.btn-primary.disabled:focus,
.btn-primary[disabled]:focus,
fieldset[disabled] .btn-primary:focus,
.btn-primary.disabled:active,
.btn-primary[disabled]:active,
fieldset[disabled] .btn-primary:active, .btn-primary.disabled.active, .btn-primary[disabled].active, fieldset[disabled] .btn-primary.active {
  background-color: #428bca;
  border-color: #357ebd; }

.btn-primary .badge {
  color: #428bca;
  background-color: #fff; }

.btn-success {
  color: #fff;
  background-color: #5cb85c;
  border-color: #4cae4c; }

.btn-success:hover, .btn-success:focus, .btn-success:active, .btn-success.active, .open .dropdown-toggle.btn-success {
  color: #fff;
  background-color: #47a447;
  border-color: #398439; }

.btn-success:active, .btn-success.active, .open .dropdown-toggle.btn-success {
  background-image: none; }

.btn-success.disabled, .btn-success[disabled], fieldset[disabled] .btn-success, .btn-success.disabled:hover, .btn-success[disabled]:hover, fieldset[disabled] .btn-success:hover, .btn-success.disabled:focus, .btn-success[disabled]:focus, fieldset[disabled] .btn-success:focus, .btn-success.disabled:active, .btn-success[disabled]:active, fieldset[disabled] .btn-success:active, .btn-success.disabled.active, .btn-success[disabled].active, fieldset[disabled] .btn-success.active {
  background-color: #5cb85c;
  border-color: #4cae4c; }

.btn-success .badge {
  color: #5cb85c;
  background-color: #fff; }

.btn-info {
  color: #fff;
  background-color: #5bc0de;
  border-color: #46b8da; }

.btn-info:hover, .btn-info:focus, .btn-info:active, .btn-info.active, .open .dropdown-toggle.btn-info {
  color: #fff;
  background-color: #39b3d7;
  border-color: #269abc; }

.btn-info:active, .btn-info.active, .open .dropdown-toggle.btn-info {
  background-image: none; }

.btn-info.disabled, .btn-info[disabled], fieldset[disabled] .btn-info, .btn-info.disabled:hover, .btn-info[disabled]:hover, fieldset[disabled] .btn-info:hover, .btn-info.disabled:focus, .btn-info[disabled]:focus, fieldset[disabled] .btn-info:focus, .btn-info.disabled:active, .btn-info[disabled]:active, fieldset[disabled] .btn-info:active, .btn-info.disabled.active, .btn-info[disabled].active, fieldset[disabled] .btn-info.active {
  background-color: #5bc0de;
  border-color: #46b8da; }

.btn-info .badge {
  color: #5bc0de;
  background-color: #fff; }

.btn-warning {
  color: #fff;
  background-color: #f0ad4e;
  border-color: #eea236; }

.btn-warning:hover, .btn-warning:focus, .btn-warning:active, .btn-warning.active, .open .dropdown-toggle.btn-warning {
  color: #fff;
  background-color: #ed9c28;
  border-color: #d58512; }

.btn-warning:active, .btn-warning.active, .open .dropdown-toggle.btn-warning {
  background-image: none; }

.btn-warning.disabled, .btn-warning[disabled], fieldset[disabled] .btn-warning, .btn-warning.disabled:hover, .btn-warning[disabled]:hover, fieldset[disabled] .btn-warning:hover, .btn-warning.disabled:focus, .btn-warning[disabled]:focus, fieldset[disabled] .btn-warning:focus, .btn-warning.disabled:active, .btn-warning[disabled]:active, fieldset[disabled] .btn-warning:active, .btn-warning.disabled.active, .btn-warning[disabled].active, fieldset[disabled] .btn-warning.active {
  background-color: #f0ad4e;
  border-color: #eea236; }

.btn-warning .badge {
  color: #f0ad4e;
  background-color: #fff; }

.btn-danger {
  color: #fff;
  background-color: #d9534f;
  border-color: #d43f3a; }

.btn-danger:hover, .btn-danger:focus, .btn-danger:active, .btn-danger.active, .open .dropdown-toggle.btn-danger {
  color: #fff;
  background-color: #d2322d;
  border-color: #ac2925; }

.btn-danger:active, .btn-danger.active, .open .dropdown-toggle.btn-danger {
  background-image: none; }

.btn-danger.disabled, .btn-danger[disabled], fieldset[disabled] .btn-danger, .btn-danger.disabled:hover, .btn-danger[disabled]:hover, fieldset[disabled] .btn-danger:hover, .btn-danger.disabled:focus, .btn-danger[disabled]:focus, fieldset[disabled] .btn-danger:focus, .btn-danger.disabled:active, .btn-danger[disabled]:active, fieldset[disabled] .btn-danger:active, .btn-danger.disabled.active, .btn-danger[disabled].active, fieldset[disabled] .btn-danger.active {
  background-color: #d9534f;
  border-color: #d43f3a; }

.btn-danger .badge {
  color: #d9534f;
  background-color: #fff; }

.btn-link {
  color: #428bca;
  font-weight: 400;
  cursor: pointer;
  border-radius: 0; }

.btn-link, .btn-link:active, .btn-link[disabled], fieldset[disabled] .btn-link {
  background-color: transparent;
  -webkit-box-shadow: none;
  box-shadow: none; }

.btn-link, .btn-link:hover, .btn-link:focus, .btn-link:active {
  border-color: transparent; }

.btn-link:hover, .btn-link:focus {
  color: #2a6496;
  text-decoration: underline;
  background-color: transparent; }

.btn-link[disabled]:hover, fieldset[disabled] .btn-link:hover, .btn-link[disabled]:focus, fieldset[disabled] .btn-link:focus {
  color: #999;
  text-decoration: none; }

.btn-lg, .btn-group-lg > .btn {
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

.btn-sm, .btn-group-sm > .btn {
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

.btn-xs, .btn-group-xs > .btn {
  padding: 1px 5px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

.btn-block {
  display: block;
  width: 100%;
  padding-left: 0;
  padding-right: 0; }

.btn-block + .btn-block {
  margin-top: 5px; }

input[type=submit].btn-block, input[type=reset].btn-block, input[type=button].btn-block {
  width: 100%; }

.fade {
  opacity: 0;
  -webkit-transition: opacity .15s linear;
  transition: opacity .15s linear; }

.fade.in {
  opacity: 1; }

.collapse {
  display: none; }

.collapse.in {
  display: block; }

.collapsing {
  position: relative;
  height: 0;
  overflow: hidden;
  -webkit-transition: height .35s ease;
  transition: height .35s ease; }

@font-face {
  font-family: 'Glyphicons Halflings';
  src: url(../fonts/glyphicons-halflings-regular.eot);
  src: url(../fonts/glyphicons-halflings-regular.eot?#iefix) format("embedded-opentype"), url(../fonts/glyphicons-halflings-regular.woff) format("woff"), url(../fonts/glyphicons-halflings-regular.ttf) format("truetype"), url(../fonts/glyphicons-halflings-regular.svg#glyphicons_halflingsregular) format("svg"); }
.glyphicon {
  position: relative;
  top: 1px;
  display: inline-block;
  font-family: 'Glyphicons Halflings';
  font-style: normal;
  font-weight: 400;
  line-height: 1;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale; }

.glyphicon-asterisk:before {
  content: "\2a"; }

.glyphicon-plus:before {
  content: "\2b"; }

.glyphicon-euro:before {
  content: "\20ac"; }

.glyphicon-minus:before {
  content: "\2212"; }

.glyphicon-cloud:before {
  content: "\2601"; }

.glyphicon-envelope:before {
  content: "\2709"; }

.glyphicon-pencil:before {
  content: "\270f"; }

.glyphicon-glass:before {
  content: "\e001"; }

.glyphicon-music:before {
  content: "\e002"; }

.glyphicon-search:before {
  content: "\e003"; }

.glyphicon-heart:before {
  content: "\e005"; }

.glyphicon-star:before {
  content: "\e006"; }

.glyphicon-star-empty:before {
  content: "\e007"; }

.glyphicon-user:before {
  content: "\e008"; }

.glyphicon-film:before {
  content: "\e009"; }

.glyphicon-th-large:before {
  content: "\e010"; }

.glyphicon-th:before {
  content: "\e011"; }

.glyphicon-th-list:before {
  content: "\e012"; }

.glyphicon-ok:before {
  content: "\e013"; }

.glyphicon-remove:before {
  content: "\e014"; }

.glyphicon-zoom-in:before {
  content: "\e015"; }

.glyphicon-zoom-out:before {
  content: "\e016"; }

.glyphicon-off:before {
  content: "\e017"; }

.glyphicon-signal:before {
  content: "\e018"; }

.glyphicon-cog:before {
  content: "\e019"; }

.glyphicon-trash:before {
  content: "\e020"; }

.glyphicon-home:before {
  content: "\e021"; }

.glyphicon-file:before {
  content: "\e022"; }

.glyphicon-time:before {
  content: "\e023"; }

.glyphicon-road:before {
  content: "\e024"; }

.glyphicon-download-alt:before {
  content: "\e025"; }

.glyphicon-download:before {
  content: "\e026"; }

.glyphicon-upload:before {
  content: "\e027"; }

.glyphicon-inbox:before {
  content: "\e028"; }

.glyphicon-play-circle:before {
  content: "\e029"; }

.glyphicon-repeat:before {
  content: "\e030"; }

.glyphicon-refresh:before {
  content: "\e031"; }

.glyphicon-list-alt:before {
  content: "\e032"; }

.glyphicon-lock:before {
  content: "\e033"; }

.glyphicon-flag:before {
  content: "\e034"; }

.glyphicon-headphones:before {
  content: "\e035"; }

.glyphicon-volume-off:before {
  content: "\e036"; }

.glyphicon-volume-down:before {
  content: "\e037"; }

.glyphicon-volume-up:before {
  content: "\e038"; }

.glyphicon-qrcode:before {
  content: "\e039"; }

.glyphicon-barcode:before {
  content: "\e040"; }

.glyphicon-tag:before {
  content: "\e041"; }

.glyphicon-tags:before {
  content: "\e042"; }

.glyphicon-book:before {
  content: "\e043"; }

.glyphicon-bookmark:before {
  content: "\e044"; }

.glyphicon-print:before {
  content: "\e045"; }

.glyphicon-camera:before {
  content: "\e046"; }

.glyphicon-font:before {
  content: "\e047"; }

.glyphicon-bold:before {
  content: "\e048"; }

.glyphicon-italic:before {
  content: "\e049"; }

.glyphicon-text-height:before {
  content: "\e050"; }

.glyphicon-text-width:before {
  content: "\e051"; }

.glyphicon-align-left:before {
  content: "\e052"; }

.glyphicon-align-center:before {
  content: "\e053"; }

.glyphicon-align-right:before {
  content: "\e054"; }

.glyphicon-align-justify:before {
  content: "\e055"; }

.glyphicon-list:before {
  content: "\e056"; }

.glyphicon-indent-left:before {
  content: "\e057"; }

.glyphicon-indent-right:before {
  content: "\e058"; }

.glyphicon-facetime-video:before {
  content: "\e059"; }

.glyphicon-picture:before {
  content: "\e060"; }

.glyphicon-map-marker:before {
  content: "\e062"; }

.glyphicon-adjust:before {
  content: "\e063"; }

.glyphicon-tint:before {
  content: "\e064"; }

.glyphicon-edit:before {
  content: "\e065"; }

.glyphicon-share:before {
  content: "\e066"; }

.glyphicon-check:before {
  content: "\e067"; }

.glyphicon-move:before {
  content: "\e068"; }

.glyphicon-step-backward:before {
  content: "\e069"; }

.glyphicon-fast-backward:before {
  content: "\e070"; }

.glyphicon-backward:before {
  content: "\e071"; }

.glyphicon-play:before {
  content: "\e072"; }

.glyphicon-pause:before {
  content: "\e073"; }

.glyphicon-stop:before {
  content: "\e074"; }

.glyphicon-forward:before {
  content: "\e075"; }

.glyphicon-fast-forward:before {
  content: "\e076"; }

.glyphicon-step-forward:before {
  content: "\e077"; }

.glyphicon-eject:before {
  content: "\e078"; }

.glyphicon-chevron-left:before {
  content: "\e079"; }

.glyphicon-chevron-right:before {
  content: "\e080"; }

.glyphicon-plus-sign:before {
  content: "\e081"; }

.glyphicon-minus-sign:before {
  content: "\e082"; }

.glyphicon-remove-sign:before {
  content: "\e083"; }

.glyphicon-ok-sign:before {
  content: "\e084"; }

.glyphicon-question-sign:before {
  content: "\e085"; }

.glyphicon-info-sign:before {
  content: "\e086"; }

.glyphicon-screenshot:before {
  content: "\e087"; }

.glyphicon-remove-circle:before {
  content: "\e088"; }

.glyphicon-ok-circle:before {
  content: "\e089"; }

.glyphicon-ban-circle:before {
  content: "\e090"; }

.glyphicon-arrow-left:before {
  content: "\e091"; }

.glyphicon-arrow-right:before {
  content: "\e092"; }

/*  arrow right but after the element */
.glyphicon-arrow-after:after {
  content: "\e092"; }

.glyphicon-arrow-up:before {
  content: "\e093"; }

.glyphicon-arrow-down:before {
  content: "\e094"; }

.glyphicon-share-alt:before {
  content: "\e095"; }

.glyphicon-resize-full:before {
  content: "\e096"; }

.glyphicon-resize-small:before {
  content: "\e097"; }

.glyphicon-exclamation-sign:before {
  content: "\e101"; }

.glyphicon-gift:before {
  content: "\e102"; }

.glyphicon-leaf:before {
  content: "\e103"; }

.glyphicon-fire:before {
  content: "\e104"; }

.glyphicon-eye-open:before {
  content: "\e105"; }

.glyphicon-eye-close:before {
  content: "\e106"; }

.glyphicon-warning-sign:before {
  content: "\e107"; }

.glyphicon-plane:before {
  content: "\e108"; }

.glyphicon-calendar:before {
  content: "\e109"; }

.glyphicon-random:before {
  content: "\e110"; }

.glyphicon-comment:before {
  content: "\e111"; }

.glyphicon-magnet:before {
  content: "\e112"; }

.glyphicon-chevron-up:before {
  content: "\e113"; }

.glyphicon-chevron-down:before {
  content: "\e114"; }

.glyphicon-retweet:before {
  content: "\e115"; }

.glyphicon-shopping-cart:before {
  content: "\e116"; }

.glyphicon-folder-close:before {
  content: "\e117"; }

.glyphicon-folder-open:before {
  content: "\e118"; }

.glyphicon-resize-vertical:before {
  content: "\e119"; }

.glyphicon-resize-horizontal:before {
  content: "\e120"; }

.glyphicon-hdd:before {
  content: "\e121"; }

.glyphicon-bullhorn:before {
  content: "\e122"; }

.glyphicon-bell:before {
  content: "\e123"; }

.glyphicon-certificate:before {
  content: "\e124"; }

.glyphicon-thumbs-up:before {
  content: "\e125"; }

.glyphicon-thumbs-down:before {
  content: "\e126"; }

.glyphicon-hand-right:before {
  content: "\e127"; }

.glyphicon-hand-left:before {
  content: "\e128"; }

.glyphicon-hand-up:before {
  content: "\e129"; }

.glyphicon-hand-down:before {
  content: "\e130"; }

.glyphicon-circle-arrow-right:before {
  content: "\e131"; }

.glyphicon-circle-arrow-left:before {
  content: "\e132"; }

.glyphicon-circle-arrow-up:before {
  content: "\e133"; }

.glyphicon-circle-arrow-down:before {
  content: "\e134"; }

.glyphicon-globe:before {
  content: "\e135"; }

.glyphicon-wrench:before {
  content: "\e136"; }

.glyphicon-tasks:before {
  content: "\e137"; }

.glyphicon-filter:before {
  content: "\e138"; }

.glyphicon-briefcase:before {
  content: "\e139"; }

.glyphicon-fullscreen:before {
  content: "\e140"; }

.glyphicon-dashboard:before {
  content: "\e141"; }

.glyphicon-paperclip:before {
  content: "\e142"; }

.glyphicon-heart-empty:before {
  content: "\e143"; }

.glyphicon-link:before {
  content: "\e144"; }

.glyphicon-phone:before {
  content: "\e145"; }

.glyphicon-pushpin:before {
  content: "\e146"; }

.glyphicon-usd:before {
  content: "\e148"; }

.glyphicon-gbp:before {
  content: "\e149"; }

.glyphicon-sort:before {
  content: "\e150"; }

.glyphicon-sort-by-alphabet:before {
  content: "\e151"; }

.glyphicon-sort-by-alphabet-alt:before {
  content: "\e152"; }

.glyphicon-sort-by-order:before {
  content: "\e153"; }

.glyphicon-sort-by-order-alt:before {
  content: "\e154"; }

.glyphicon-sort-by-attributes:before {
  content: "\e155"; }

.glyphicon-sort-by-attributes-alt:before {
  content: "\e156"; }

.glyphicon-unchecked:before {
  content: "\e157"; }

.glyphicon-expand:before {
  content: "\e158"; }

.glyphicon-collapse-down:before {
  content: "\e159"; }

.glyphicon-collapse-up:before {
  content: "\e160"; }

.glyphicon-log-in:before {
  content: "\e161"; }

.glyphicon-flash:before {
  content: "\e162"; }

.glyphicon-log-out:before {
  content: "\e163"; }

.glyphicon-new-window:before {
  content: "\e164"; }

.glyphicon-record:before {
  content: "\e165"; }

.glyphicon-save:before {
  content: "\e166"; }

.glyphicon-open:before {
  content: "\e167"; }

.glyphicon-saved:before {
  content: "\e168"; }

.glyphicon-import:before {
  content: "\e169"; }

.glyphicon-export:before {
  content: "\e170"; }

.glyphicon-send:before {
  content: "\e171"; }

.glyphicon-floppy-disk:before {
  content: "\e172"; }

.glyphicon-floppy-saved:before {
  content: "\e173"; }

.glyphicon-floppy-remove:before {
  content: "\e174"; }

.glyphicon-floppy-save:before {
  content: "\e175"; }

.glyphicon-floppy-open:before {
  content: "\e176"; }

.glyphicon-credit-card:before {
  content: "\e177"; }

.glyphicon-transfer:before {
  content: "\e178"; }

.glyphicon-cutlery:before {
  content: "\e179"; }

.glyphicon-header:before {
  content: "\e180"; }

.glyphicon-compressed:before {
  content: "\e181"; }

.glyphicon-earphone:before {
  content: "\e182"; }

.glyphicon-phone-alt:before {
  content: "\e183"; }

.glyphicon-tower:before {
  content: "\e184"; }

.glyphicon-stats:before {
  content: "\e185"; }

.glyphicon-sd-video:before {
  content: "\e186"; }

.glyphicon-hd-video:before {
  content: "\e187"; }

.glyphicon-subtitles:before {
  content: "\e188"; }

.glyphicon-sound-stereo:before {
  content: "\e189"; }

.glyphicon-sound-dolby:before {
  content: "\e190"; }

.glyphicon-sound-5-1:before {
  content: "\e191"; }

.glyphicon-sound-6-1:before {
  content: "\e192"; }

.glyphicon-sound-7-1:before {
  content: "\e193"; }

.glyphicon-copyright-mark:before {
  content: "\e194"; }

.glyphicon-registration-mark:before {
  content: "\e195"; }

.glyphicon-cloud-download:before {
  content: "\e197"; }

.glyphicon-cloud-upload:before {
  content: "\e198"; }

.glyphicon-tree-conifer:before {
  content: "\e199"; }

.glyphicon-tree-deciduous:before {
  content: "\e200"; }

.caret {
  display: inline-block;
  width: 0;
  height: 0;
  margin-left: 2px;
  vertical-align: middle;
  border-top: 4px solid;
  border-right: 4px solid transparent;
  border-left: 4px solid transparent; }

.dropdown {
  position: relative; }

.dropdown-toggle:focus {
  outline: 0; }

.dropdown-menu {
  position: absolute;
  top: 100%;
  left: 0;
  z-index: 1000;
  display: none;
  float: left;
  min-width: 160px;
  padding: 5px 0;
  margin: 2px 0 0;
  list-style: none;
  font-size: 14px;
  background-color: #fff;
  border: 1px solid #ccc;
  border: 1px solid rgba(0, 0, 0, 0.15);
  border-radius: 4px;
  -webkit-box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  box-shadow: 0 6px 12px rgba(0, 0, 0, 0.175);
  background-clip: padding-box; }

.dropdown-menu.pull-right {
  right: 0;
  left: auto; }

.dropdown-menu .divider {
  height: 1px;
  margin: 9px 0;
  overflow: hidden;
  background-color: #e5e5e5; }

.dropdown-menu > li > a {
  display: block;
  padding: 3px 20px;
  clear: both;
  font-weight: 400;
  line-height: 1.42857143;
  color: #333;
  white-space: nowrap; }

.dropdown-menu > li > a:hover, .dropdown-menu > li > a:focus {
  text-decoration: none;
  color: #262626;
  background-color: #f5f5f5; }

.dropdown-menu > .active > a, .dropdown-menu > .active > a:hover, .dropdown-menu > .active > a:focus {
  color: #fff;
  text-decoration: none;
  outline: 0;
  background-color: #428bca; }

.dropdown-menu > .disabled > a, .dropdown-menu > .disabled > a:hover, .dropdown-menu > .disabled > a:focus {
  color: #999; }

.dropdown-menu > .disabled > a:hover, .dropdown-menu > .disabled > a:focus {
  text-decoration: none;
  background-color: transparent;
  background-image: none;
  filter: progid:DXImageTransform.Microsoft.gradient(enabled=false);
  cursor: not-allowed; }

.open > .dropdown-menu {
  display: block; }

.open > a {
  outline: 0; }

.dropdown-menu-right {
  left: auto;
  right: 0; }

.dropdown-menu-left {
  left: 0;
  right: auto; }

.dropdown-header {
  display: block;
  padding: 3px 20px;
  font-size: 12px;
  line-height: 1.42857143;
  color: #999; }

.dropdown-backdrop {
  position: fixed;
  left: 0;
  right: 0;
  bottom: 0;
  top: 0;
  z-index: 990; }

.pull-right > .dropdown-menu {
  right: 0;
  left: auto; }

.dropup .caret, .navbar-fixed-bottom .dropdown .caret {
  border-top: 0;
  border-bottom: 4px solid;
  content: ""; }

.dropup .dropdown-menu, .navbar-fixed-bottom .dropdown .dropdown-menu {
  top: auto;
  bottom: 100%;
  margin-bottom: 1px; }

@media (min-width: 768px) {
  .navbar-right .dropdown-menu {
    left: auto;
    right: 0; }

  .navbar-right .dropdown-menu-left {
    left: 0;
    right: auto; } }
.btn-group, .btn-group-vertical {
  position: relative;
  display: inline-block;
  vertical-align: middle; }

.btn-group > .btn, .btn-group-vertical > .btn {
  position: relative;
  float: left; }

.btn-group > .btn:hover, .btn-group-vertical > .btn:hover, .btn-group > .btn:focus, .btn-group-vertical > .btn:focus, .btn-group > .btn:active, .btn-group-vertical > .btn:active, .btn-group > .btn.active, .btn-group-vertical > .btn.active {
  z-index: 2; }

.btn-group > .btn:focus, .btn-group-vertical > .btn:focus {
  outline: 0; }

.btn-group .btn + .btn, .btn-group .btn + .btn-group, .btn-group .btn-group + .btn, .btn-group .btn-group + .btn-group {
  margin-left: -1px; }

.btn-toolbar {
  margin-left: -5px; }

.btn-toolbar .btn-group, .btn-toolbar .input-group {
  float: left; }

.btn-toolbar > .btn, .btn-toolbar > .btn-group, .btn-toolbar > .input-group {
  margin-left: 5px; }

.btn-group > .btn:not(:first-child):not(:last-child):not(.dropdown-toggle) {
  border-radius: 0; }

.btn-group > .btn:first-child {
  margin-left: 0; }

.btn-group > .btn:first-child:not(:last-child):not(.dropdown-toggle) {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.btn-group > .btn:last-child:not(:first-child), .btn-group > .dropdown-toggle:not(:first-child) {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.btn-group > .btn-group {
  float: left; }

.btn-group > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0; }

.btn-group > .btn-group:first-child > .btn:last-child, .btn-group > .btn-group:first-child > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.btn-group > .btn-group:last-child > .btn:first-child {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.btn-group .dropdown-toggle:active, .btn-group.open .dropdown-toggle {
  outline: 0; }

.btn-group > .btn + .dropdown-toggle {
  padding-left: 8px;
  padding-right: 8px; }

.btn-group > .btn-lg + .dropdown-toggle {
  padding-left: 12px;
  padding-right: 12px; }

.btn-group.open .dropdown-toggle {
  -webkit-box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125);
  box-shadow: inset 0 3px 5px rgba(0, 0, 0, 0.125); }

.btn-group.open .dropdown-toggle.btn-link {
  -webkit-box-shadow: none;
  box-shadow: none; }

.btn .caret {
  margin-left: 0; }

.btn-lg .caret {
  border-width: 5px 5px 0;
  border-bottom-width: 0; }

.dropup .btn-lg .caret {
  border-width: 0 5px 5px; }

.btn-group-vertical > .btn, .btn-group-vertical > .btn-group, .btn-group-vertical > .btn-group > .btn {
  display: block;
  float: none;
  width: 100%;
  max-width: 100%; }

.btn-group-vertical > .btn-group > .btn {
  float: none; }

.btn-group-vertical > .btn + .btn, .btn-group-vertical > .btn + .btn-group, .btn-group-vertical > .btn-group + .btn, .btn-group-vertical > .btn-group + .btn-group {
  margin-top: -1px;
  margin-left: 0; }

.btn-group-vertical > .btn:not(:first-child):not(:last-child) {
  border-radius: 0; }

.btn-group-vertical > .btn:first-child:not(:last-child) {
  border-top-right-radius: 4px;
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.btn-group-vertical > .btn:last-child:not(:first-child) {
  border-bottom-left-radius: 4px;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.btn-group-vertical > .btn-group:not(:first-child):not(:last-child) > .btn {
  border-radius: 0; }

.btn-group-vertical > .btn-group:first-child:not(:last-child) > .btn:last-child, .btn-group-vertical > .btn-group:first-child:not(:last-child) > .dropdown-toggle {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.btn-group-vertical > .btn-group:last-child:not(:first-child) > .btn:first-child {
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.btn-group-justified {
  display: table;
  width: 100%;
  table-layout: fixed;
  border-collapse: separate; }

.btn-group-justified > .btn, .btn-group-justified > .btn-group {
  float: none;
  display: table-cell;
  width: 1%; }

.btn-group-justified > .btn-group .btn {
  width: 100%; }

[data-toggle=buttons] > .btn > input[type=radio], [data-toggle=buttons] > .btn > input[type=checkbox] {
  display: none; }

.input-group {
  position: relative;
  display: table;
  border-collapse: separate; }

.input-group[class*=col-] {
  float: none;
  padding-left: 0;
  padding-right: 0; }

.input-group .form-control {
  position: relative;
  z-index: 2;
  float: left;
  width: 100%;
  margin-bottom: 0; }

.input-group-lg > .form-control, .input-group-lg > .input-group-addon, .input-group-lg > .input-group-btn > .btn {
  height: 46px;
  padding: 10px 16px;
  font-size: 18px;
  line-height: 1.33;
  border-radius: 6px; }

select.input-group-lg > .form-control, select.input-group-lg > .input-group-addon, select.input-group-lg > .input-group-btn > .btn {
  height: 46px;
  line-height: 46px; }

textarea.input-group-lg > .form-control, textarea.input-group-lg > .input-group-addon, textarea.input-group-lg > .input-group-btn > .btn, select[multiple].input-group-lg > .form-control, select[multiple].input-group-lg > .input-group-addon, select[multiple].input-group-lg > .input-group-btn > .btn {
  height: auto; }

.input-group-sm > .form-control, .input-group-sm > .input-group-addon, .input-group-sm > .input-group-btn > .btn {
  height: 30px;
  padding: 5px 10px;
  font-size: 12px;
  line-height: 1.5;
  border-radius: 3px; }

select.input-group-sm > .form-control, select.input-group-sm > .input-group-addon, select.input-group-sm > .input-group-btn > .btn {
  height: 30px;
  line-height: 30px; }

textarea.input-group-sm > .form-control, textarea.input-group-sm > .input-group-addon, textarea.input-group-sm > .input-group-btn > .btn, select[multiple].input-group-sm > .form-control, select[multiple].input-group-sm > .input-group-addon, select[multiple].input-group-sm > .input-group-btn > .btn {
  height: auto; }

.input-group-addon, .input-group-btn, .input-group .form-control {
  display: table-cell; }

.input-group-addon:not(:first-child):not(:last-child), .input-group-btn:not(:first-child):not(:last-child), .input-group .form-control:not(:first-child):not(:last-child) {
  border-radius: 0; }

.input-group-addon, .input-group-btn {
  width: 1%;
  white-space: nowrap;
  vertical-align: middle; }

.input-group-addon {
  padding: 6px 12px;
  font-size: 14px;
  font-weight: 400;
  line-height: 1;
  color: #555;
  text-align: center;
  background-color: #eee;
  border: 1px solid #ccc;
  border-radius: 4px; }

.input-group-addon.input-sm {
  padding: 5px 10px;
  font-size: 12px;
  border-radius: 3px; }

.input-group-addon.input-lg {
  padding: 10px 16px;
  font-size: 18px;
  border-radius: 6px; }

.input-group-addon input[type=radio], .input-group-addon input[type=checkbox] {
  margin-top: 0; }

.input-group .form-control:first-child, .input-group-addon:first-child, .input-group-btn:first-child > .btn, .input-group-btn:first-child > .btn-group > .btn, .input-group-btn:first-child > .dropdown-toggle, .input-group-btn:last-child > .btn:not(:last-child):not(.dropdown-toggle), .input-group-btn:last-child > .btn-group:not(:last-child) > .btn {
  border-bottom-right-radius: 0;
  border-top-right-radius: 0; }

.input-group-addon:first-child {
  border-right: 0; }

.input-group .form-control:last-child, .input-group-addon:last-child, .input-group-btn:last-child > .btn, .input-group-btn:last-child > .btn-group > .btn, .input-group-btn:last-child > .dropdown-toggle, .input-group-btn:first-child > .btn:not(:first-child), .input-group-btn:first-child > .btn-group:not(:first-child) > .btn {
  border-bottom-left-radius: 0;
  border-top-left-radius: 0; }

.input-group-addon:last-child {
  border-left: 0; }

.input-group-btn {
  position: relative;
  font-size: 0;
  white-space: nowrap; }

.input-group-btn > .btn {
  position: relative; }

.input-group-btn > .btn + .btn {
  margin-left: -1px; }

.input-group-btn > .btn:hover, .input-group-btn > .btn:focus, .input-group-btn > .btn:active {
  z-index: 2; }

.input-group-btn:first-child > .btn, .input-group-btn:first-child > .btn-group {
  margin-right: -1px; }

.input-group-btn:last-child > .btn, .input-group-btn:last-child > .btn-group {
  margin-left: -1px; }

.nav {
  margin-bottom: 0;
  padding-left: 0;
  list-style: none; }

.nav > li {
  position: relative;
  display: block; }

.nav > li > a {
  position: relative;
  display: block;
  padding: 10px 15px; }

.nav > li > a:hover, .nav > li > a:focus {
  text-decoration: none;
  background-color: #eee; }

.nav > li.disabled > a {
  color: #999; }

.nav > li.disabled > a:hover, .nav > li.disabled > a:focus {
  color: #999;
  text-decoration: none;
  background-color: transparent;
  cursor: not-allowed; }

.nav .open > a, .nav .open > a:hover, .nav .open > a:focus {
  background-color: #eee;
  border-color: #428bca; }

.nav .nav-divider {
  height: 1px;
  margin: 9px 0;
  overflow: hidden;
  background-color: #e5e5e5; }

.nav > li > a > img {
  max-width: none; }

.nav-tabs {
  border-bottom: 1px solid #ddd; }

.nav-tabs > li {
  float: left;
  margin-bottom: -1px; }

.nav-tabs > li > a {
  margin-right: 2px;
  line-height: 1.42857143;
  border: 1px solid transparent;
  border-radius: 4px 4px 0 0; }

.nav-tabs > li > a:hover {
  border-color: #eee #eee #ddd; }

.nav-tabs > li.active > a, .nav-tabs > li.active > a:hover, .nav-tabs > li.active > a:focus {
  color: #555;
  background-color: #fff;
  border: 1px solid #ddd;
  border-bottom-color: transparent;
  cursor: default; }

.nav-tabs.nav-justified {
  width: 100%;
  border-bottom: 0; }

.nav-tabs.nav-justified > li {
  float: none; }

.nav-tabs.nav-justified > li > a {
  text-align: center;
  margin-bottom: 5px; }

.nav-tabs.nav-justified > .dropdown .dropdown-menu {
  top: auto;
  left: auto; }

@media (min-width: 768px) {
  .nav-tabs.nav-justified > li {
    display: table-cell;
    width: 1%; }

  .nav-tabs.nav-justified > li > a {
    margin-bottom: 0; } }
.nav-tabs.nav-justified > li > a {
  margin-right: 0;
  border-radius: 4px; }

.nav-tabs.nav-justified > .active > a, .nav-tabs.nav-justified > .active > a:hover, .nav-tabs.nav-justified > .active > a:focus {
  border: 1px solid #ddd; }

@media (min-width: 768px) {
  .nav-tabs.nav-justified > li > a {
    border-bottom: 1px solid #ddd;
    border-radius: 4px 4px 0 0; }

  .nav-tabs.nav-justified > .active > a, .nav-tabs.nav-justified > .active > a:hover, .nav-tabs.nav-justified > .active > a:focus {
    border-bottom-color: #fff; } }
.nav-pills > li {
  float: left; }

.nav-pills > li > a {
  border-radius: 4px; }

.nav-pills > li + li {
  margin-left: 2px; }

.nav-pills > li.active > a, .nav-pills > li.active > a:hover, .nav-pills > li.active > a:focus {
  color: #fff;
  background-color: #428bca; }

.nav-stacked > li {
  float: none; }

.nav-stacked > li + li {
  margin-top: 2px;
  margin-left: 0; }

.nav-justified {
  width: 100%; }

.nav-justified > li {
  float: none; }

.nav-justified > li > a {
  text-align: center;
  margin-bottom: 5px; }

.nav-justified > .dropdown .dropdown-menu {
  top: auto;
  left: auto; }

@media (min-width: 768px) {
  .nav-justified > li {
    display: table-cell;
    width: 1%; }

  .nav-justified > li > a {
    margin-bottom: 0; } }
.nav-tabs-justified {
  border-bottom: 0; }

.nav-tabs-justified > li > a {
  margin-right: 0;
  border-radius: 4px; }

.nav-tabs-justified > .active > a, .nav-tabs-justified > .active > a:hover, .nav-tabs-justified > .active > a:focus {
  border: 1px solid #ddd; }

@media (min-width: 768px) {
  .nav-tabs-justified > li > a {
    border-bottom: 1px solid #ddd;
    border-radius: 4px 4px 0 0; }

  .nav-tabs-justified > .active > a, .nav-tabs-justified > .active > a:hover, .nav-tabs-justified > .active > a:focus {
    border-bottom-color: #fff; } }
.tab-content > .tab-pane {
  display: none; }

.tab-content > .active {
  display: block; }

.nav-tabs .dropdown-menu {
  margin-top: -1px;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.navbar {
  position: relative;
  min-height: 50px;
  margin-bottom: 20px;
  border: 1px solid transparent; }

@media (min-width: 768px) {
  .navbar {
    border-radius: 4px; } }
@media (min-width: 768px) {
  .navbar-header {
    float: left; } }
.navbar-collapse {
  max-height: 340px;
  overflow-x: visible;
  padding-right: 15px;
  padding-left: 15px;
  border-top: 1px solid transparent;
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1);
  -webkit-overflow-scrolling: touch; }

.navbar-collapse.in {
  overflow-y: auto; }

@media (min-width: 768px) {
  .navbar-collapse {
    width: auto;
    border-top: 0;
    box-shadow: none; }

  .navbar-collapse.collapse {
    display: block !important;
    height: auto !important;
    padding-bottom: 0;
    overflow: visible !important; }

  .navbar-collapse.in {
    overflow-y: visible; }

  .navbar-fixed-top .navbar-collapse, .navbar-static-top .navbar-collapse, .navbar-fixed-bottom .navbar-collapse {
    padding-left: 0;
    padding-right: 0; } }
.container > .navbar-header, .container-fluid > .navbar-header, .container > .navbar-collapse, .container-fluid > .navbar-collapse {
  margin-right: -15px;
  margin-left: -15px; }

@media (min-width: 768px) {
  .container > .navbar-header, .container-fluid > .navbar-header, .container > .navbar-collapse, .container-fluid > .navbar-collapse {
    margin-right: 0;
    margin-left: 0; } }
.navbar-static-top {
  z-index: 1000;
  border-width: 0 0 1px; }

@media (min-width: 768px) {
  .navbar-static-top {
    border-radius: 0; } }
.navbar-fixed-top, .navbar-fixed-bottom {
  position: fixed;
  right: 0;
  left: 0;
  z-index: 1030; }

@media (min-width: 768px) {
  .navbar-fixed-top, .navbar-fixed-bottom {
    border-radius: 0; } }
.navbar-fixed-top {
  top: 0;
  border-width: 0 0 1px; }

.navbar-fixed-bottom {
  bottom: 0;
  margin-bottom: 0;
  border-width: 1px 0 0; }

.navbar-brand {
  float: left;
  padding: 15px;
  font-size: 18px;
  line-height: 20px;
  height: 50px; }

.navbar-brand:hover, .navbar-brand:focus {
  text-decoration: none; }

@media (min-width: 768px) {
  .navbar > .container .navbar-brand, .navbar > .container-fluid .navbar-brand {
    margin-left: -15px; } }
.navbar-toggle {
  position: relative;
  float: right;
  margin-right: 15px;
  padding: 9px 10px;
  margin-top: 8px;
  margin-bottom: 8px;
  background-color: transparent;
  background-image: none;
  border: 1px solid transparent;
  border-radius: 4px; }

.navbar-toggle:focus {
  outline: 0; }

.navbar-toggle .icon-bar {
  display: block;
  width: 22px;
  height: 2px;
  border-radius: 1px; }

.navbar-toggle .icon-bar + .icon-bar {
  margin-top: 4px; }

@media (min-width: 768px) {
  .navbar-toggle {
    display: none; } }
.navbar-nav {
  margin: 7.5px -15px; }

.navbar-nav > li > a {
  padding-top: 10px;
  padding-bottom: 10px;
  line-height: 20px; }

@media (max-width: 767px) {
  .navbar-nav .open .dropdown-menu {
    position: static;
    float: none;
    width: auto;
    margin-top: 0;
    background-color: transparent;
    border: 0;
    box-shadow: none; }

  .navbar-nav .open .dropdown-menu > li > a, .navbar-nav .open .dropdown-menu .dropdown-header {
    padding: 5px 15px 5px 25px; }

  .navbar-nav .open .dropdown-menu > li > a {
    line-height: 20px; }

  .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-nav .open .dropdown-menu > li > a:focus {
    background-image: none; } }
@media (min-width: 768px) {
  .navbar-nav {
    float: left;
    margin: 0; }

  .navbar-nav > li {
    float: left; }

  .navbar-nav > li > a {
    padding-top: 15px;
    padding-bottom: 15px; }

  .navbar-nav.navbar-right:last-child {
    margin-right: -15px; } }
@media (min-width: 768px) {
  .navbar-left {
    float: left !important; }

  .navbar-right {
    float: right !important; } }
.navbar-form {
  margin-left: -15px;
  margin-right: -15px;
  padding: 10px 15px;
  border-top: 1px solid transparent;
  border-bottom: 1px solid transparent;
  -webkit-box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
  box-shadow: inset 0 1px 0 rgba(255, 255, 255, 0.1), 0 1px 0 rgba(255, 255, 255, 0.1);
  margin-top: 8px;
  margin-bottom: 8px; }

@media (min-width: 768px) {
  .navbar-form .form-group {
    display: inline-block;
    margin-bottom: 0;
    vertical-align: middle; }

  .navbar-form .form-control {
    display: inline-block;
    width: auto;
    vertical-align: middle; }

  .navbar-form .input-group > .form-control {
    width: 100%; }

  .navbar-form .control-label {
    margin-bottom: 0;
    vertical-align: middle; }

  .navbar-form .radio, .navbar-form .checkbox {
    display: inline-block;
    margin-top: 0;
    margin-bottom: 0;
    padding-left: 0;
    vertical-align: middle; }

  .navbar-form .radio input[type=radio], .navbar-form .checkbox input[type=checkbox] {
    float: none;
    margin-left: 0; }

  .navbar-form .has-feedback .form-control-feedback {
    top: 0; } }
@media (max-width: 767px) {
  .navbar-form .form-group {
    margin-bottom: 5px; } }
@media (min-width: 768px) {
  .navbar-form {
    width: auto;
    border: 0;
    margin-left: 0;
    margin-right: 0;
    padding-top: 0;
    padding-bottom: 0;
    -webkit-box-shadow: none;
    box-shadow: none; }

  .navbar-form.navbar-right:last-child {
    margin-right: -15px; } }
.navbar-nav > li > .dropdown-menu {
  margin-top: 0;
  border-top-right-radius: 0;
  border-top-left-radius: 0; }

.navbar-fixed-bottom .navbar-nav > li > .dropdown-menu {
  border-bottom-right-radius: 0;
  border-bottom-left-radius: 0; }

.navbar-btn {
  margin-top: 8px;
  margin-bottom: 8px; }

.navbar-btn.btn-sm {
  margin-top: 10px;
  margin-bottom: 10px; }

.navbar-btn.btn-xs {
  margin-top: 14px;
  margin-bottom: 14px; }

.navbar-text {
  margin-top: 15px;
  margin-bottom: 15px; }

@media (min-width: 768px) {
  .navbar-text {
    float: left;
    margin-left: 15px;
    margin-right: 15px; }

  .navbar-text.navbar-right:last-child {
    margin-right: 0; } }
.navbar-default {
  background-color: #f8f8f8;
  border-color: #e7e7e7; }

.navbar-default .navbar-brand {
  color: #777; }

.navbar-default .navbar-brand:hover, .navbar-default .navbar-brand:focus {
  color: #5e5e5e;
  background-color: transparent; }

.navbar-default .navbar-text {
  color: #777; }

.navbar-default .navbar-nav > li > a {
  color: #777; }

.navbar-default .navbar-nav > li > a:hover, .navbar-default .navbar-nav > li > a:focus {
  color: #333;
  background-color: transparent; }

.navbar-default .navbar-nav > .active > a, .navbar-default .navbar-nav > .active > a:hover, .navbar-default .navbar-nav > .active > a:focus {
  color: #555;
  background-color: #e7e7e7; }

.navbar-default .navbar-nav > .disabled > a, .navbar-default .navbar-nav > .disabled > a:hover, .navbar-default .navbar-nav > .disabled > a:focus {
  color: #ccc;
  background-color: transparent; }

.navbar-default .navbar-toggle {
  border-color: #ddd; }

.navbar-default .navbar-toggle:hover, .navbar-default .navbar-toggle:focus {
  background-color: #ddd; }

.navbar-default .navbar-toggle .icon-bar {
  background-color: #888; }

.navbar-default .navbar-collapse, .navbar-default .navbar-form {
  border-color: #e7e7e7; }

.navbar-default .navbar-nav > .open > a, .navbar-default .navbar-nav > .open > a:hover, .navbar-default .navbar-nav > .open > a:focus {
  background-color: #e7e7e7;
  color: #555; }

@media (max-width: 767px) {
  .navbar-default .navbar-nav .open .dropdown-menu > li > a {
    color: #777; }

  .navbar-default .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #333;
    background-color: transparent; }

  .navbar-default .navbar-nav .open .dropdown-menu > .active > a, .navbar-default .navbar-nav .open .dropdown-menu > .active > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #555;
    background-color: #e7e7e7; }

  .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a, .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:hover, .navbar-default .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #ccc;
    background-color: transparent; } }
.navbar-default .navbar-link {
  color: #777; }

.navbar-default .navbar-link:hover {
  color: #333; }

.navbar-inverse {
  background-color: transparent;
  border: medium none;
  margin-bottom: 0; }

.navbar-inverse .navbar-brand {
  color: #999; }

.navbar-inverse .navbar-brand:hover, .navbar-inverse .navbar-brand:focus {
  color: #fff;
  background-color: transparent; }

.navbar-inverse .navbar-text {
  color: #999; }

.navbar-inverse .navbar-nav > li > a {
  color: #999; }

.navbar-inverse .navbar-nav > li > a:hover,
.navbar-inverse .navbar-nav > li > a:focus {
  color: #1788ca;
  background-color: transparent; }

.navbar-inverse .navbar-nav > .active > a, .navbar-inverse .navbar-nav > .active > a:hover, .navbar-inverse .navbar-nav > .active > a:focus {
  color: #fff;
  background-color: #080808; }

.navbar-inverse .navbar-nav > .disabled > a,
.navbar-inverse .navbar-nav > .disabled > a:hover,
.navbar-inverse .navbar-nav > .disabled > a:focus {
  color: #444;
  background-color: transparent; }

.navbar-inverse .navbar-toggle {
  border-color: #333; }

.navbar-inverse .navbar-toggle:hover, .navbar-inverse .navbar-toggle:focus {
  background-color: #333; }

.navbar-inverse .navbar-toggle .icon-bar {
  background-color: #fff; }

.navbar-inverse .navbar-collapse, .navbar-inverse .navbar-form {
  border-color: #101010; }

.navbar-inverse .navbar-nav > .open > a, .navbar-inverse .navbar-nav > .open > a:hover, .navbar-inverse .navbar-nav > .open > a:focus {
  background-color: #080808;
  color: #fff; }

@media (max-width: 767px) {
  .navbar-inverse .navbar-nav .open .dropdown-menu > .dropdown-header {
    border-color: #080808; }

  .navbar-inverse .navbar-nav .open .dropdown-menu .divider {
    background-color: #080808; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a {
    color: #999; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > li > a:focus {
    color: #fff;
    background-color: transparent; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a, .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > .active > a:focus {
    color: #fff;
    background-color: #080808; }

  .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a, .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:hover, .navbar-inverse .navbar-nav .open .dropdown-menu > .disabled > a:focus {
    color: #444;
    background-color: transparent; } }
.navbar-inverse .navbar-link {
  color: #999; }

.navbar-inverse .navbar-link:hover {
  color: #fff; }

.breadcrumb {
  padding: 8px 15px;
  margin-bottom: 20px;
  list-style: none;
  background-color: #f5f5f5;
  border-radius: 4px; }

.breadcrumb > li {
  display: inline-block; }

.breadcrumb > li + li:before {
  content: "/\00a0";
  padding: 0 5px;
  color: #ccc; }

.breadcrumb > .active {
  color: #999; }

.pagination {
  display: inline-block;
  padding-left: 0;
  margin: 20px 0;
  border-radius: 4px; }

.pagination > li {
  display: inline; }

.pagination > li > a, .pagination > li > span {
  position: relative;
  float: left;
  padding: 6px 12px;
  line-height: 1.42857143;
  text-decoration: none;
  color: #428bca;
  background-color: #fff;
  border: 1px solid #ddd;
  margin-left: -1px; }

.pagination > li:first-child > a, .pagination > li:first-child > span {
  margin-left: 0;
  border-bottom-left-radius: 4px;
  border-top-left-radius: 4px; }

.pagination > li:last-child > a, .pagination > li:last-child > span {
  border-bottom-right-radius: 4px;
  border-top-right-radius: 4px; }

.pagination > li > a:hover, .pagination > li > span:hover, .pagination > li > a:focus, .pagination > li > span:focus {
  color: #2a6496;
  background-color: #eee;
  border-color: #ddd; }

.pagination > .active > a, .pagination > .active > span, .pagination > .active > a:hover, .pagination > .active > span:hover, .pagination > .active > a:focus, .pagination > .active > span:focus {
  z-index: 2;
  color: #fff;
  background-color: #428bca;
  border-color: #428bca;
  cursor: default; }

.pagination > .disabled > span, .pagination > .disabled > span:hover, .pagination > .disabled > span:focus, .pagination > .disabled > a, .pagination > .disabled > a:hover, .pagination > .disabled > a:focus {
  color: #999;
  background-color: #fff;
  border-color: #ddd;
  cursor: not-allowed; }

.pagination-lg > li > a, .pagination-lg > li > span {
  padding: 10px 16px;
  font-size: 18px; }

.pagination-lg > li:first-child > a, .pagination-lg > li:first-child > span {
  border-bottom-left-radius: 6px;
  border-top-left-radius: 6px; }

.pagination-lg > li:last-child > a, .pagination-lg > li:last-child > span {
  border-bottom-right-radius: 6px;
  border-top-right-radius: 6px; }

.pagination-sm > li > a, .pagination-sm > li > span {
  padding: 5px 10px;
  font-size: 12px; }

.pagination-sm > li:first-child > a, .pagination-sm > li:first-child > span {
  border-bottom-left-radius: 3px;
  border-top-left-radius: 3px; }

.pagination-sm > li:last-child > a, .pagination-sm > li:last-child > span {
  border-bottom-right-radius: 3px;
  border-top-right-radius: 3px; }

.pager {
  padding-left: 0;
  margin: 20px 0;
  list-style: none;
  text-align: center; }

.pager li {
  display: inline; }

.pager li > a, .pager li > span {
  display: inline-block;
  padding: 5px 14px;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 15px; }

.pager li > a:hover, .pager li > a:focus {
  text-decoration: none;
  background-color: #eee; }

.pager .next > a, .pager .next > span {
  float: right; }

.pager .previous > a, .pager .previous > span {
  float: left; }

.pager .disabled > a, .pager .disabled > a:hover, .pager .disabled > a:focus, .pager .disabled > span {
  color: #999;
  background-color: #fff;
  cursor: not-allowed; }

.label {
  display: inline;
  padding: .2em .6em .3em;
  font-size: 75%;
  font-weight: 700;
  line-height: 1;
  color: #fff;
  text-align: center;
  white-space: nowrap;
  vertical-align: baseline;
  border-radius: .25em; }

.label[href]:hover, .label[href]:focus {
  color: #fff;
  text-decoration: none;
  cursor: pointer; }

.label:empty {
  display: none; }

.btn .label {
  position: relative;
  top: -1px; }

.label-default {
  background-color: #999; }

.label-default[href]:hover, .label-default[href]:focus {
  background-color: gray; }

.label-primary {
  background-color: #428bca; }

.label-primary[href]:hover, .label-primary[href]:focus {
  background-color: #3071a9; }

.label-success {
  background-color: #5cb85c; }

.label-success[href]:hover, .label-success[href]:focus {
  background-color: #449d44; }

.label-info {
  background-color: #5bc0de; }

.label-info[href]:hover, .label-info[href]:focus {
  background-color: #31b0d5; }

.label-warning {
  background-color: #f0ad4e; }

.label-warning[href]:hover, .label-warning[href]:focus {
  background-color: #ec971f; }

.label-danger {
  background-color: #d9534f; }

.label-danger[href]:hover, .label-danger[href]:focus {
  background-color: #c9302c; }

.badge {
  display: inline-block;
  min-width: 10px;
  padding: 3px 7px;
  font-size: 12px;
  font-weight: 700;
  color: #fff;
  line-height: 1;
  vertical-align: baseline;
  white-space: nowrap;
  text-align: center;
  background-color: #999;
  border-radius: 10px; }

.badge:empty {
  display: none; }

.btn .badge {
  position: relative;
  top: -1px; }

.btn-xs .badge {
  top: 0;
  padding: 1px 5px; }

a.badge:hover, a.badge:focus {
  color: #fff;
  text-decoration: none;
  cursor: pointer; }

a.list-group-item.active > .badge, .nav-pills > .active > a > .badge {
  color: #428bca;
  background-color: #fff; }

.nav-pills > li > a > .badge {
  margin-left: 3px; }

.jumbotron {
  padding: 30px;
  margin-bottom: 30px;
  color: inherit;
  background-color: #eee; }

.jumbotron h1, .jumbotron .h1 {
  color: inherit; }

.jumbotron p {
  margin-bottom: 15px;
  font-size: 21px;
  font-weight: 200; }

.container .jumbotron {
  border-radius: 6px; }

.jumbotron .container {
  max-width: 100%; }

@media screen and (min-width: 768px) {
  .jumbotron {
    padding-top: 48px;
    padding-bottom: 48px; }

  .container .jumbotron {
    padding-left: 60px;
    padding-right: 60px; }

  .jumbotron h1, .jumbotron .h1 {
    font-size: 63px; } }
.thumbnail {
  display: block;
  padding: 4px;
  margin-bottom: 20px;
  line-height: 1.42857143;
  background-color: #fff;
  border: 1px solid #ddd;
  border-radius: 4px;
  -webkit-transition: all .2s ease-in-out;
  transition: all .2s ease-in-out; }

.thumbnail > img, .thumbnail a > img {
  margin-left: auto;
  margin-right: auto; }

a.thumbnail:hover, a.thumbnail:focus, a.thumbnail.active {
  border-color: #428bca; }

.thumbnail .caption {
  padding: 9px;
  color: #333; }

.alert {
  padding: 15px;
  margin-bottom: 20px;
  border: 1px solid transparent;
  border-radius: 4px; }

.alert h4 {
  margin-top: 0;
  color: inherit; }

.alert .alert-link {
  font-weight: 700; }

.alert > p, .alert > ul {
  margin-bottom: 0; }

.alert > p + p {
  margin-top: 5px; }

.alert-dismissable {
  padding-right: 35px; }

.alert-dismissable .close {
  position: relative;
  top: -2px;
  right: -21px;
  color: inherit; }

.alert-success {
  background-color: #dff0d8;
  border-color: #d6e9c6;
  color: #3c763d; }

.alert-success hr {
  border-top-color: #c9e2b3; }

.alert-success .alert-link {
  color: #2b542c; }

.alert-info {
  background-color: #d9edf7;
  border-color: #bce8f1;
  color: #31708f; }

.alert-info hr {
  border-top-color: #a6e1ec; }

.alert-info .alert-link {
  color: #245269; }

.alert-warning {
  background-color: #fcf8e3;
  border-color: #faebcc;
  color: #8a6d3b; }

.alert-warning hr {
  border-top-color: #f7e1b5; }

.alert-warning .alert-link {
  color: #66512c; }

.alert-danger {
  background-color: #f2dede;
  border-color: #ebccd1;
  color: #a94442; }

.alert-danger hr {
  border-top-color: #e4b9c0; }

.alert-danger .alert-link {
  color: #843534; }

@-webkit-keyframes progress-bar-stripes {
  from {
    background-position: 40px 0; }
  to {
    background-position: 0 0; } }
@keyframes progress-bar-stripes {
  from {
    background-position: 40px 0; }
  to {
    background-position: 0 0; } }
.progress {
  overflow: hidden;
  height: 20px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1);
  box-shadow: inset 0 1px 2px rgba(0, 0, 0, 0.1); }

.progress-bar {
  float: left;
  width: 0;
  height: 100%;
  font-size: 12px;
  line-height: 20px;
  color: #fff;
  text-align: center;
  background-color: #428bca;
  -webkit-box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  box-shadow: inset 0 -1px 0 rgba(0, 0, 0, 0.15);
  -webkit-transition: width .6s ease;
  transition: width .6s ease; }

.progress-striped .progress-bar {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-size: 40px 40px; }

.progress.active .progress-bar {
  -webkit-animation: progress-bar-stripes 2s linear infinite;
  animation: progress-bar-stripes 2s linear infinite; }

.progress-bar-success {
  background-color: #5cb85c; }

.progress-striped .progress-bar-success {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-info {
  background-color: #5bc0de; }

.progress-striped .progress-bar-info {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-warning {
  background-color: #f0ad4e; }

.progress-striped .progress-bar-warning {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.progress-bar-danger {
  background-color: #d9534f; }

.progress-striped .progress-bar-danger {
  background-image: -webkit-linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent);
  background-image: linear-gradient(45deg, rgba(255, 255, 255, 0.15) 25%, transparent 25%, transparent 50%, rgba(255, 255, 255, 0.15) 50%, rgba(255, 255, 255, 0.15) 75%, transparent 75%, transparent); }

.media, .media-body {
  overflow: hidden;
  zoom: 1; }

.media, .media .media {
  margin-top: 15px; }

.media:first-child {
  margin-top: 0; }

.media-object {
  display: block; }

.media-heading {
  margin: 0 0 5px; }

.media > .pull-left {
  margin-right: 10px; }

.media > .pull-right {
  margin-left: 10px; }

.media-list {
  padding-left: 0;
  list-style: none; }

.list-group {
  margin-bottom: 20px;
  padding-left: 0; }

.list-group-item {
  position: relative;
  display: block;
  padding: 10px 15px;
  margin-bottom: -1px;
  background-color: #fff;
  border: 1px solid #ddd; }

.list-group-item:first-child {
  border-top-right-radius: 4px;
  border-top-left-radius: 4px; }

.list-group-item:last-child {
  margin-bottom: 0;
  border-bottom-right-radius: 4px;
  border-bottom-left-radius: 4px; }

.list-group-item > .badge {
  float: right; }

.list-group-item > .badge + .badge {
  margin-right: 5px; }

a.list-group-item {
  color: #555; }

a.list-group-item .list-group-item-heading {
  color: #333; }

a.list-group-item:hover, a.list-group-item:focus {
  text-decoration: none;
  background-color: #f5f5f5; }

a.list-group-item.active, a.list-group-item.active:hover, a.list-group-item.active:focus {
  z-index: 2;
  color: #fff;
  background-color: #428bca;
  border-color: #428bca; }

a.list-group-item.active .list-group-item-heading, a.list-group-item.active:hover .list-group-item-heading, a.list-group-item.active:focus .list-group-item-heading {
  color: inherit; }

a.list-group-item.active .list-group-item-text, a.list-group-item.active:hover .list-group-item-text, a.list-group-item.active:focus .list-group-item-text {
  color: #e1edf7; }

.list-group-item-success {
  color: #3c763d;
  background-color: #dff0d8; }

a.list-group-item-success {
  color: #3c763d; }

a.list-group-item-success .list-group-item-heading {
  color: inherit; }

a.list-group-item-success:hover, a.list-group-item-success:focus {
  color: #3c763d;
  background-color: #d0e9c6; }

a.list-group-item-success.active, a.list-group-item-success.active:hover, a.list-group-item-success.active:focus {
  color: #fff;
  background-color: #3c763d;
  border-color: #3c763d; }

.list-group-item-info {
  color: #31708f;
  background-color: #d9edf7; }

a.list-group-item-info {
  color: #31708f; }

a.list-group-item-info .list-group-item-heading {
  color: inherit; }

a.list-group-item-info:hover, a.list-group-item-info:focus {
  color: #31708f;
  background-color: #c4e3f3; }

a.list-group-item-info.active, a.list-group-item-info.active:hover, a.list-group-item-info.active:focus {
  color: #fff;
  background-color: #31708f;
  border-color: #31708f; }

.list-group-item-warning {
  color: #8a6d3b;
  background-color: #fcf8e3; }

a.list-group-item-warning {
  color: #8a6d3b; }

a.list-group-item-warning .list-group-item-heading {
  color: inherit; }

a.list-group-item-warning:hover, a.list-group-item-warning:focus {
  color: #8a6d3b;
  background-color: #faf2cc; }

a.list-group-item-warning.active, a.list-group-item-warning.active:hover, a.list-group-item-warning.active:focus {
  color: #fff;
  background-color: #8a6d3b;
  border-color: #8a6d3b; }

.list-group-item-danger {
  color: #a94442;
  background-color: #f2dede; }

a.list-group-item-danger {
  color: #a94442; }

a.list-group-item-danger .list-group-item-heading {
  color: inherit; }

a.list-group-item-danger:hover, a.list-group-item-danger:focus {
  color: #a94442;
  background-color: #ebcccc; }

a.list-group-item-danger.active, a.list-group-item-danger.active:hover, a.list-group-item-danger.active:focus {
  color: #fff;
  background-color: #a94442;
  border-color: #a94442; }

.list-group-item-heading {
  margin-top: 0;
  margin-bottom: 5px; }

.list-group-item-text {
  margin-bottom: 0;
  line-height: 1.3; }

.panel {
  margin-bottom: 20px;
  background-color: #fff;
  border: 1px solid transparent;
  border-radius: 4px;
  -webkit-box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: 0 1px 1px rgba(0, 0, 0, 0.05); }

.panel-body {
  padding: 15px; }

.panel-heading {
  padding: 10px 15px;
  border-bottom: 1px solid transparent;
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }

.panel-heading > .dropdown .dropdown-toggle {
  color: inherit; }

.panel-title {
  margin-top: 0;
  margin-bottom: 0;
  font-size: 16px;
  color: inherit; }

.panel-title > a {
  color: inherit; }

.panel-footer {
  padding: 10px 15px;
  background-color: #f5f5f5;
  border-top: 1px solid #ddd;
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel > .list-group {
  margin-bottom: 0; }

.panel > .list-group .list-group-item {
  border-width: 1px 0;
  border-radius: 0; }

.panel > .list-group:first-child .list-group-item:first-child {
  border-top: 0;
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }

.panel > .list-group:last-child .list-group-item:last-child {
  border-bottom: 0;
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel-heading + .list-group .list-group-item:first-child {
  border-top-width: 0; }

.panel > .table, .panel > .table-responsive > .table {
  margin-bottom: 0; }

.panel > .table:first-child, .panel > .table-responsive:first-child > .table:first-child {
  border-top-right-radius: 3px;
  border-top-left-radius: 3px; }

.panel > .table:first-child > thead:first-child > tr:first-child td:first-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child td:first-child, .panel > .table:first-child > tbody:first-child > tr:first-child td:first-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child td:first-child, .panel > .table:first-child > thead:first-child > tr:first-child th:first-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child th:first-child, .panel > .table:first-child > tbody:first-child > tr:first-child th:first-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child th:first-child {
  border-top-left-radius: 3px; }

.panel > .table:first-child > thead:first-child > tr:first-child td:last-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child td:last-child, .panel > .table:first-child > tbody:first-child > tr:first-child td:last-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child td:last-child, .panel > .table:first-child > thead:first-child > tr:first-child th:last-child, .panel > .table-responsive:first-child > .table:first-child > thead:first-child > tr:first-child th:last-child, .panel > .table:first-child > tbody:first-child > tr:first-child th:last-child, .panel > .table-responsive:first-child > .table:first-child > tbody:first-child > tr:first-child th:last-child {
  border-top-right-radius: 3px; }

.panel > .table:last-child, .panel > .table-responsive:last-child > .table:last-child {
  border-bottom-right-radius: 3px;
  border-bottom-left-radius: 3px; }

.panel > .table:last-child > tbody:last-child > tr:last-child td:first-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child td:first-child, .panel > .table:last-child > tfoot:last-child > tr:last-child td:first-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child td:first-child, .panel > .table:last-child > tbody:last-child > tr:last-child th:first-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child th:first-child, .panel > .table:last-child > tfoot:last-child > tr:last-child th:first-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child th:first-child {
  border-bottom-left-radius: 3px; }

.panel > .table:last-child > tbody:last-child > tr:last-child td:last-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child td:last-child, .panel > .table:last-child > tfoot:last-child > tr:last-child td:last-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child td:last-child, .panel > .table:last-child > tbody:last-child > tr:last-child th:last-child, .panel > .table-responsive:last-child > .table:last-child > tbody:last-child > tr:last-child th:last-child, .panel > .table:last-child > tfoot:last-child > tr:last-child th:last-child, .panel > .table-responsive:last-child > .table:last-child > tfoot:last-child > tr:last-child th:last-child {
  border-bottom-right-radius: 3px; }

.panel > .panel-body + .table, .panel > .panel-body + .table-responsive {
  border-top: 1px solid #ddd; }

.panel > .table > tbody:first-child > tr:first-child th, .panel > .table > tbody:first-child > tr:first-child td {
  border-top: 0; }

.panel > .table-bordered, .panel > .table-responsive > .table-bordered {
  border: 0; }

.panel > .table-bordered > thead > tr > th:first-child, .panel > .table-responsive > .table-bordered > thead > tr > th:first-child, .panel > .table-bordered > tbody > tr > th:first-child, .panel > .table-responsive > .table-bordered > tbody > tr > th:first-child, .panel > .table-bordered > tfoot > tr > th:first-child, .panel > .table-responsive > .table-bordered > tfoot > tr > th:first-child, .panel > .table-bordered > thead > tr > td:first-child, .panel > .table-responsive > .table-bordered > thead > tr > td:first-child, .panel > .table-bordered > tbody > tr > td:first-child, .panel > .table-responsive > .table-bordered > tbody > tr > td:first-child, .panel > .table-bordered > tfoot > tr > td:first-child, .panel > .table-responsive > .table-bordered > tfoot > tr > td:first-child {
  border-left: 0; }

.panel > .table-bordered > thead > tr > th:last-child, .panel > .table-responsive > .table-bordered > thead > tr > th:last-child, .panel > .table-bordered > tbody > tr > th:last-child, .panel > .table-responsive > .table-bordered > tbody > tr > th:last-child, .panel > .table-bordered > tfoot > tr > th:last-child, .panel > .table-responsive > .table-bordered > tfoot > tr > th:last-child, .panel > .table-bordered > thead > tr > td:last-child, .panel > .table-responsive > .table-bordered > thead > tr > td:last-child, .panel > .table-bordered > tbody > tr > td:last-child, .panel > .table-responsive > .table-bordered > tbody > tr > td:last-child, .panel > .table-bordered > tfoot > tr > td:last-child, .panel > .table-responsive > .table-bordered > tfoot > tr > td:last-child {
  border-right: 0; }

.panel > .table-bordered > thead > tr:first-child > td, .panel > .table-responsive > .table-bordered > thead > tr:first-child > td, .panel > .table-bordered > tbody > tr:first-child > td, .panel > .table-responsive > .table-bordered > tbody > tr:first-child > td, .panel > .table-bordered > thead > tr:first-child > th, .panel > .table-responsive > .table-bordered > thead > tr:first-child > th, .panel > .table-bordered > tbody > tr:first-child > th, .panel > .table-responsive > .table-bordered > tbody > tr:first-child > th {
  border-bottom: 0; }

.panel > .table-bordered > tbody > tr:last-child > td, .panel > .table-responsive > .table-bordered > tbody > tr:last-child > td, .panel > .table-bordered > tfoot > tr:last-child > td, .panel > .table-responsive > .table-bordered > tfoot > tr:last-child > td, .panel > .table-bordered > tbody > tr:last-child > th, .panel > .table-responsive > .table-bordered > tbody > tr:last-child > th, .panel > .table-bordered > tfoot > tr:last-child > th, .panel > .table-responsive > .table-bordered > tfoot > tr:last-child > th {
  border-bottom: 0; }

.panel > .table-responsive {
  border: 0;
  margin-bottom: 0; }

.panel-group {
  margin-bottom: 20px; }

.panel-group .panel {
  margin-bottom: 0;
  border-radius: 4px;
  overflow: hidden; }

.panel-group .panel + .panel {
  margin-top: 5px; }

.panel-group .panel-heading {
  border-bottom: 0; }

.panel-group .panel-heading + .panel-collapse .panel-body {
  border-top: 1px solid #ddd; }

.panel-group .panel-footer {
  border-top: 0; }

.panel-group .panel-footer + .panel-collapse .panel-body {
  border-bottom: 1px solid #ddd; }

.panel-default {
  border-color: #ddd; }

.panel-default > .panel-heading {
  color: #333;
  background-color: #f5f5f5;
  border-color: #ddd; }

.panel-default > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #ddd; }

.panel-default > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #ddd; }

.panel-primary {
  border-color: #428bca; }

.panel-primary > .panel-heading {
  color: #fff;
  background-color: #428bca;
  border-color: #428bca; }

.panel-primary > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #428bca; }

.panel-primary > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #428bca; }

.panel-success {
  border-color: #d6e9c6; }

.panel-success > .panel-heading {
  color: #3c763d;
  background-color: #dff0d8;
  border-color: #d6e9c6; }

.panel-success > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #d6e9c6; }

.panel-success > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #d6e9c6; }

.panel-info {
  border-color: #bce8f1; }

.panel-info > .panel-heading {
  color: #31708f;
  background-color: #d9edf7;
  border-color: #bce8f1; }

.panel-info > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #bce8f1; }

.panel-info > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #bce8f1; }

.panel-warning {
  border-color: #faebcc; }

.panel-warning > .panel-heading {
  color: #8a6d3b;
  background-color: #fcf8e3;
  border-color: #faebcc; }

.panel-warning > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #faebcc; }

.panel-warning > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #faebcc; }

.panel-danger {
  border-color: #ebccd1; }

.panel-danger > .panel-heading {
  color: #a94442;
  background-color: #f2dede;
  border-color: #ebccd1; }

.panel-danger > .panel-heading + .panel-collapse .panel-body {
  border-top-color: #ebccd1; }

.panel-danger > .panel-footer + .panel-collapse .panel-body {
  border-bottom-color: #ebccd1; }

.well {
  min-height: 20px;
  padding: 19px;
  margin-bottom: 20px;
  background-color: #f5f5f5;
  border: 1px solid #e3e3e3;
  border-radius: 4px;
  -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05);
  box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.05); }

.well blockquote {
  border-color: #ddd;
  border-color: rgba(0, 0, 0, 0.15); }

.well-lg {
  padding: 24px;
  border-radius: 6px; }

.well-sm {
  padding: 9px;
  border-radius: 3px; }

.close {
  float: right;
  font-size: 21px;
  font-weight: 700;
  line-height: 1;
  color: #000;
  text-shadow: 0 1px 0 #fff;
  opacity: .2;
  filter: alpha(opacity=20); }

.close:hover, .close:focus {
  color: #000;
  text-decoration: none;
  cursor: pointer;
  opacity: .5;
  filter: alpha(opacity=50); }

button.close {
  padding: 0;
  cursor: pointer;
  background: 0 0;
  border: 0;
  -webkit-appearance: none; }

.modal-open {
  overflow: hidden; }

.modal {
  display: none;
  overflow: auto;
  overflow-y: scroll;
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1050;
  -webkit-overflow-scrolling: touch;
  outline: 0; }

.modal.fade .modal-dialog {
  -webkit-transform: translate(0, -25%);
  -ms-transform: translate(0, -25%);
  transform: translate(0, -25%);
  -webkit-transition: -webkit-transform .3s ease-out;
  -moz-transition: -moz-transform .3s ease-out;
  -o-transition: -o-transform .3s ease-out;
  transition: transform .3s ease-out; }

.modal.in .modal-dialog {
  -webkit-transform: translate(0, 0);
  -ms-transform: translate(0, 0);
  transform: translate(0, 0); }

.modal-dialog {
  position: relative;
  width: auto;
  margin: 10px; }

.modal-content {
  position: relative;
  background-color: #fff;
  border: 1px solid #999;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 6px;
  -webkit-box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  box-shadow: 0 3px 9px rgba(0, 0, 0, 0.5);
  background-clip: padding-box;
  outline: 0; }

.modal-backdrop {
  position: fixed;
  top: 0;
  right: 0;
  bottom: 0;
  left: 0;
  z-index: 1040;
  background-color: #000; }

.modal-backdrop.fade {
  opacity: 0;
  filter: alpha(opacity=0); }

.modal-backdrop.in {
  opacity: .5;
  filter: alpha(opacity=50); }

.modal-header {
  padding: 15px;
  border-bottom: 1px solid #e5e5e5;
  min-height: 16.42857143px; }

.modal-header .close {
  margin-top: -2px; }

.modal-title {
  margin: 0;
  line-height: 1.42857143; }

.modal-body {
  position: relative;
  padding: 20px; }

.modal-footer {
  margin-top: 15px;
  padding: 19px 20px 20px;
  text-align: right;
  border-top: 1px solid #e5e5e5; }

.modal-footer .btn + .btn {
  margin-left: 5px;
  margin-bottom: 0; }

.modal-footer .btn-group .btn + .btn {
  margin-left: -1px; }

.modal-footer .btn-block + .btn-block {
  margin-left: 0; }

@media (min-width: 768px) {
  .modal-dialog {
    width: 600px;
    margin: 30px auto; }

  .modal-content {
    -webkit-box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5);
    box-shadow: 0 5px 15px rgba(0, 0, 0, 0.5); }

  .modal-sm {
    width: 300px; } }
@media (min-width: 992px) {
  .modal-lg {
    width: 900px; } }
.tooltip {
  position: absolute;
  z-index: 1030;
  display: block;
  visibility: visible;
  font-size: 12px;
  line-height: 1.4;
  opacity: 0;
  filter: alpha(opacity=0); }

.tooltip.in {
  opacity: .9;
  filter: alpha(opacity=90); }

.tooltip.top {
  margin-top: -3px;
  padding: 5px 0; }

.tooltip.right {
  margin-left: 3px;
  padding: 0 5px; }

.tooltip.bottom {
  margin-top: 3px;
  padding: 5px 0; }

.tooltip.left {
  margin-left: -3px;
  padding: 0 5px; }

.tooltip-inner {
  max-width: 200px;
  padding: 3px 8px;
  color: #fff;
  text-align: center;
  text-decoration: none;
  background-color: #000;
  border-radius: 4px; }

.tooltip-arrow {
  position: absolute;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid; }

.tooltip.top .tooltip-arrow {
  bottom: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 5px 5px 0;
  border-top-color: #000; }

.tooltip.top-left .tooltip-arrow {
  bottom: 0;
  left: 5px;
  border-width: 5px 5px 0;
  border-top-color: #000; }

.tooltip.top-right .tooltip-arrow {
  bottom: 0;
  right: 5px;
  border-width: 5px 5px 0;
  border-top-color: #000; }

.tooltip.right .tooltip-arrow {
  top: 50%;
  left: 0;
  margin-top: -5px;
  border-width: 5px 5px 5px 0;
  border-right-color: #000; }

.tooltip.left .tooltip-arrow {
  top: 50%;
  right: 0;
  margin-top: -5px;
  border-width: 5px 0 5px 5px;
  border-left-color: #000; }

.tooltip.bottom .tooltip-arrow {
  top: 0;
  left: 50%;
  margin-left: -5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000; }

.tooltip.bottom-left .tooltip-arrow {
  top: 0;
  left: 5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000; }

.tooltip.bottom-right .tooltip-arrow {
  top: 0;
  right: 5px;
  border-width: 0 5px 5px;
  border-bottom-color: #000; }

.popover {
  position: absolute;
  top: 0;
  left: 0;
  z-index: 1010;
  display: none;
  max-width: 276px;
  padding: 1px;
  text-align: left;
  background-color: #fff;
  background-clip: padding-box;
  border: 1px solid #ccc;
  border: 1px solid rgba(0, 0, 0, 0.2);
  border-radius: 6px;
  -webkit-box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  box-shadow: 0 5px 10px rgba(0, 0, 0, 0.2);
  white-space: normal; }

.popover.top {
  margin-top: -10px; }

.popover.right {
  margin-left: 10px; }

.popover.bottom {
  margin-top: 10px; }

.popover.left {
  margin-left: -10px; }

.popover-title {
  margin: 0;
  padding: 8px 14px;
  font-size: 14px;
  font-weight: 400;
  line-height: 18px;
  background-color: #f7f7f7;
  border-bottom: 1px solid #ebebeb;
  border-radius: 5px 5px 0 0; }

.popover-content {
  padding: 9px 14px; }

.popover > .arrow, .popover > .arrow:after {
  position: absolute;
  display: block;
  width: 0;
  height: 0;
  border-color: transparent;
  border-style: solid; }

.popover > .arrow {
  border-width: 11px; }

.popover > .arrow:after {
  border-width: 10px;
  content: ""; }

.popover.top > .arrow {
  left: 50%;
  margin-left: -11px;
  border-bottom-width: 0;
  border-top-color: #999;
  border-top-color: rgba(0, 0, 0, 0.25);
  bottom: -11px; }

.popover.top > .arrow:after {
  content: " ";
  bottom: 1px;
  margin-left: -10px;
  border-bottom-width: 0;
  border-top-color: #fff; }

.popover.right > .arrow {
  top: 50%;
  left: -11px;
  margin-top: -11px;
  border-left-width: 0;
  border-right-color: #999;
  border-right-color: rgba(0, 0, 0, 0.25); }

.popover.right > .arrow:after {
  content: " ";
  left: 1px;
  bottom: -10px;
  border-left-width: 0;
  border-right-color: #fff; }

.popover.bottom > .arrow {
  left: 50%;
  margin-left: -11px;
  border-top-width: 0;
  border-bottom-color: #999;
  border-bottom-color: rgba(0, 0, 0, 0.25);
  top: -11px; }

.popover.bottom > .arrow:after {
  content: " ";
  top: 1px;
  margin-left: -10px;
  border-top-width: 0;
  border-bottom-color: #fff; }

.popover.left > .arrow {
  top: 50%;
  right: -11px;
  margin-top: -11px;
  border-right-width: 0;
  border-left-color: #999;
  border-left-color: rgba(0, 0, 0, 0.25); }

.popover.left > .arrow:after {
  content: " ";
  right: 1px;
  border-right-width: 0;
  border-left-color: #fff;
  bottom: -10px; }

.carousel-inner > .item {
  display: none;
  position: relative;
  -webkit-transition: .6s ease-in-out left;
  transition: .6s ease-in-out left; }

.carousel-inner > .item > img, .carousel-inner > .item > a > img {
  line-height: 1; }

.carousel-inner > .active {
  left: 0; }

.carousel-inner > .next, .carousel-inner > .prev {
  position: absolute;
  top: 0;
  width: 100%; }

.carousel-inner > .next {
  left: 100%; }

.carousel-inner > .prev {
  left: -100%; }

.carousel-inner > .next.left, .carousel-inner > .prev.right {
  left: 0; }

.carousel-inner > .active.left {
  left: -100%; }

.carousel-inner > .active.right {
  left: 100%; }

.carousel-control {
  position: absolute;
  top: 0;
  left: 0;
  bottom: 0;
  width: 15%;
  opacity: .5;
  filter: alpha(opacity=50);
  font-size: 20px;
  color: #fff;
  text-align: center;
  text-shadow: 0 1px 2px rgba(0, 0, 0, 0.6); }
  .carousel-control .left {
    background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.5) 0), color-stop(rgba(0, 0, 0, 0.0001) 100%));
    background-image: linear-gradient(to right, rgba(0, 0, 0, 0.5) 0, rgba(0, 0, 0, 0.0001) 100%);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#80000000', endColorstr='#00000000', GradientType=1); }
  .carousel-control .right {
    left: auto;
    right: 0;
    background-image: -webkit-linear-gradient(left, color-stop(rgba(0, 0, 0, 0.0001) 0), color-stop(rgba(0, 0, 0, 0.5) 100%));
    background-image: linear-gradient(to right, rgba(0, 0, 0, 0.0001) 0, rgba(0, 0, 0, 0.5) 100%);
    background-repeat: repeat-x;
    filter: progid:DXImageTransform.Microsoft.gradient(startColorstr='#00000000', endColorstr='#80000000', GradientType=1); }
  .carousel-control:hover, .carousel-control:focus {
    outline: 0;
    color: #fff;
    text-decoration: none;
    opacity: .9;
    filter: alpha(opacity=90); }
  .carousel-control .icon-prev,
  .carousel-control .icon-next,
  .carousel-control .glyphicon-chevron-left,
  .carousel-control .glyphicon-chevron-right {
    position: absolute;
    top: 50%;
    z-index: 5;
    display: inline-block; }
  .carousel-control .icon-prev,
  .carousel-control .glyphicon-chevron-left {
    left: 50%; }
  .carousel-control .icon-next,
  .carousel-control .glyphicon-chevron-right {
    right: 50%; }
  .carousel-control .icon-prev,
  .carousel-control .icon-next {
    width: 20px;
    height: 20px;
    margin-top: -10px;
    margin-left: -10px;
    font-family: serif; }
  .carousel-control .icon-prev:before {
    content: '\2039'; }
  .carousel-control .icon-next:before {
    content: '\203a'; }

.carousel-indicators li {
  display: inline-block;
  width: 10px;
  height: 10px;
  margin: 1px;
  text-indent: -999px;
  border: 1px solid #fff;
  border-radius: 10px;
  cursor: pointer;
  background-color: #000 \9;
  background-color: transparent; }

.carousel-indicators .active {
  margin: 0;
  width: 12px;
  height: 12px;
  background-color: #fff; }

.carousel-caption {
  color: #fff;
  left: 15%;
  padding-bottom: 20px;
  position: absolute;
  right: 15%;
  text-align: center;
  top: 26%;
  z-index: 10; }

.carousel-caption .btn {
  text-shadow: none; }

.clearfix:before, .clearfix:after, .container:before, .container:after, .container-fluid:before, .container-fluid:after, .row:before, .row:after, .form-horizontal .form-group:before, .form-horizontal .form-group:after, .btn-toolbar:before, .btn-toolbar:after, .btn-group-vertical > .btn-group:before, .btn-group-vertical > .btn-group:after, .nav:before, .nav:after, .navbar:before, .navbar:after, .navbar-header:before, .navbar-header:after, .navbar-collapse:before, .navbar-collapse:after, .pager:before, .pager:after, .panel-body:before, .panel-body:after, .modal-footer:before, .modal-footer:after {
  content: " ";
  display: table; }

.clearfix:after, .container:after, .container-fluid:after, .row:after, .form-horizontal .form-group:after, .btn-toolbar:after, .btn-group-vertical > .btn-group:after, .nav:after, .navbar:after, .navbar-header:after, .navbar-collapse:after, .pager:after, .panel-body:after, .modal-footer:after {
  clear: both; }

.center-block {
  display: block;
  margin-left: auto;
  margin-right: auto; }

.pull-right {
  float: right !important; }

.pull-left {
  float: left !important; }

.hide {
  display: none !important; }

.show {
  display: block !important; }

.invisible {
  visibility: hidden; }

.text-hide {
  font: 0/0 a;
  color: transparent;
  text-shadow: none;
  background-color: transparent;
  border: 0; }

.hidden {
  display: none !important;
  visibility: hidden !important; }

.affix {
  position: fixed; }

@-ms-viewport {
  width: device-width; }
.visible-xs, .visible-sm, .visible-md, .visible-lg {
  display: none !important; }

@media (max-width: 767px) {
  .visible-xs {
    display: block !important; }

  table.visible-xs {
    display: table; }

  tr.visible-xs {
    display: table-row !important; }

  th.visible-xs, td.visible-xs {
    display: table-cell !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm {
    display: block !important; }

  table.visible-sm {
    display: table; }

  tr.visible-sm {
    display: table-row !important; }

  th.visible-sm, td.visible-sm {
    display: table-cell !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md {
    display: block !important; }

  table.visible-md {
    display: table; }

  tr.visible-md {
    display: table-row !important; }

  th.visible-md, td.visible-md {
    display: table-cell !important; } }
@media (min-width: 1200px) {
  .visible-lg {
    display: block !important; }

  table.visible-lg {
    display: table; }

  tr.visible-lg {
    display: table-row !important; }

  th.visible-lg, td.visible-lg {
    display: table-cell !important; } }
@media (max-width: 767px) {
  .hidden-xs {
    display: none !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .hidden-sm {
    display: none !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-md {
    display: none !important; } }
@media (min-width: 1200px) {
  .hidden-lg {
    display: none !important; } }
.visible-print {
  display: none !important; }

@media print {
  .visible-print {
    display: block !important; }

  table.visible-print {
    display: table; }

  tr.visible-print {
    display: table-row !important; }

  th.visible-print, td.visible-print {
    display: table-cell !important; } }
@media print {
  .hidden-print {
    display: none !important; } }
@media (min-width: 1200px) {
  .visible-lg {
    display: block !important; }

  table.visible-lg {
    display: table; }

  tr.visible-lg {
    display: table-row !important; }

  th.visible-lg,
  td.visible-lg {
    display: table-cell !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .visible-md {
    display: block !important; }

  table.visible-md {
    display: table; }

  tr.visible-md {
    display: table-row !important; }

  th.visible-md,
  td.visible-md {
    display: table-cell !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .visible-sm {
    display: block !important; }

  table.visible-sm {
    display: table; }

  tr.visible-sm {
    display: table-row !important; }

  th.visible-sm,
  td.visible-sm {
    display: table-cell !important; } }
@-ms-viewport {
  width: device-width; }
.visible-xs,
.visible-sm,
.visible-md,
.visible-lg {
  display: none !important; }

@media (max-width: 767px) {
  .visible-xs {
    display: block !important; }

  table.visible-xs {
    display: table; }

  tr.visible-xs {
    display: table-row !important; }

  th.visible-xs,
  td.visible-xs {
    display: table-cell !important; } }
@media (max-width: 767px) {
  .hidden-xs {
    display: none !important; } }
@media (min-width: 768px) and (max-width: 991px) {
  .hidden-sm {
    display: none !important; } }
@media (min-width: 992px) and (max-width: 1199px) {
  .hidden-md {
    display: none !important; } }
@media (min-width: 1200px) {
  .hidden-lg {
    display: none !important; } }
.visible-print {
  display: none !important; }

@media print {
  .visible-print {
    display: block !important; }

  table.visible-print {
    display: table; }

  tr.visible-print {
    display: table-row !important; }

  th.visible-print,
  td.visible-print {
    display: table-cell !important; } }
@media screen and (min-width: 768px) {
  .carousel-control .glyphicon-chevron-left,
  .carousel-control .glyphicon-chevron-right,
  .carousel-control .icon-prev,
  .carousel-control .icon-next {
    width: 30px;
    height: 30px;
    margin-top: -15px;
    margin-left: -15px;
    font-size: 30px; }

  .carousel-caption {
    right: 20%;
    left: 20%;
    padding-bottom: 30px; }

  .carousel-indicators {
    bottom: 20px; } }
@media screen and (min-width: 768px) {
  .carousel-control .glyphicon-chevron-left, .carousel-control .glyphicon-chevron-right, .carousel-control .icon-prev, .carousel-control .icon-next {
    width: 30px;
    height: 30px;
    margin-top: -15px;
    margin-left: -15px;
    font-size: 30px; }

  .carousel-caption {
    left: 20%;
    right: 20%;
    padding-bottom: 30px; }

  .carousel-indicators {
    bottom: 20px; } }
/*  Partials - CSS and SASS for specific elements ----- */
/* GLOBAL STYLES
-------------------------------------------------- */
/* Padding below the footer and lighter body text */
body {
  padding-bottom: 40px;
  color: #5a5a5a; }

.carousel-indicators {
  bottom: 5%;
  height: 9px;
  left: 50%;
  list-style: outside none none;
  margin-left: -30%;
  padding-left: 0;
  position: absolute;
  text-align: center;
  width: 60%;
  z-index: 15; }

.moreOne {
  background-color: #1888ca;
  float: left;
  padding-bottom: 5px;
  padding-top: 5px;
  position: relative;
  text-align: center;
  width: 100%; }

/* CUSTOMIZE THE NAVBAR
-------------------------------------------------- */
/* Special class on .container surrounding .navbar, used for positioning it into place. */
/* Flip around the padding for proper display in narrow viewports */
.navbar-wrapper > .container {
  padding-right: 0;
  padding-left: 0; }

.navbar-wrapper .navbar {
  padding-right: 15px;
  padding-left: 15px; }

.navbar-wrapper .navbar .container {
  width: auto; }

/* CUSTOMIZE THE CAROUSEL
-------------------------------------------------- */
/* Carousel base class */
.carousel {
  height: 96%;
  max-height: 815px;
  position: relative;
  width: 100%; }

/* Since positioning the image, we need to help out the caption */
.carousel-caption {
  z-index: 10; }

/* Declare heights because of positioning of img element */
.carousel .item {
  background-color: #777;
  float: left;
  height: 100%;
  width: 100%; }

.carousel-inner > .item > img {
  height: 100%;
  left: 0;
  position: absolute;
  top: 0;
  width: 100%; }

.carousel-inner > .active,
.carousel-inner > .next,
.carousel-inner > .prev {
  display: block;
  height: 99%;
  width: 100%; }

/* MARKETING CONTENT
-------------------------------------------------- */
/* Center align the text within the three columns below the carousel */
.marketing .col-lg-4 {
  margin-bottom: 20px;
  text-align: center; }

.marketing h2 {
  font-weight: normal; }

.marketing .col-lg-4 p {
  margin-right: 10px;
  margin-left: 10px; }

#blogSlide.carousel-caption {
  top: 14%;
  text-align: left; }

#blogSlide.carousel-caption h1 {
  color: #1788ca;
  font-size: 3em;
  text-transform: uppercase;
  margin-top: 0; }

#blogSlide.carousel-caption h1 span {
  color: #df1c22; }

h1.prediktion-header {
  color: #fff;
  font-size: 3em;
  position: relative;
  text-align: center;
  text-transform: uppercase;
  top: 50px;
  width: 100%; }

#blogSlide.carousel-caption h3 {
  color: #fff;
  display: block;
  float: left;
  font-size: 5em;
  line-height: 1.2em;
  margin-top: 51px;
  text-transform: none;
  width: 48%;
  height: 374px;
  overflow: hidden; }

#blogSlide.carousel-caption .btn-primary {
  display: block;
  float: left;
  margin: 0;
  top: 20px; }

/* Featurettes
------------------------- */
.featurette-divider {
  margin: 80px 0;
  /* Space out the Bootstrap <hr> more */ }

/* Thin out the marketing headings */
.featurette-heading {
  font-weight: 300;
  line-height: 1;
  letter-spacing: -1px; }

/* RESPONSIVE CSS
-------------------------------------------------- */
@media (min-width: 768px) {
  /* Navbar positioning foo */
  .navbar-wrapper .container {
    padding-right: 15px;
    padding-left: 15px; }

  .navbar-wrapper .navbar {
    padding-right: 0;
    padding-left: 0; }

  /* The navbar becomes detached from the top, so we round the corners */
  .navbar-wrapper .navbar {
    border-radius: 0;
    background-color: transparent; }

  /* Bump up size of carousel content */
  .carousel-caption p {
    margin-bottom: 20px;
    font-size: 21px;
    line-height: 1.4; }

  .featurette-heading {
    font-size: 50px; } }
@media (min-width: 992px) {
  .featurette-heading {
    margin-top: 120px; } }
@-moz-document url-prefix() {
  fieldset {
    display: table-cell; } }
/*  Dash board SASS -------------------------- */
#dashboard-wrapper {
  /*  HEADER -----------------------------*/
  /*  HEADER -----------------------------*/ }
  #dashboard-wrapper .no-display {
    display: none; }
  #dashboard-wrapper .navbar-wrapper #PrediktaTop {
    width: 100%;
    max-width: none;
    padding-left: 0;
    padding-right: 0; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container {
      padding-left: 0;
      padding-right: 0; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li h3 {
        float: right;
        font-size: 1.5em;
        margin-bottom: 0;
        margin-right: 4%;
        margin-top: 17px;
        max-width: 320px;
        transform: scale(0.8, 1);
        -webkit-transform: scale(0.8, 1);
        /* Safari and Chrome */
        -moz-transform: scale(0.8, 1);
        /* Firefox */
        -ms-transform: scale(0.8, 1);
        /* IE 9+ */
        -o-transform: scale(0.8, 1);
        /* Opera */
        text-align: center;
        text-transform: uppercase;
        width: 100%; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li h3 span {
          display: block;
          font-size: 0.7em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem {
        width: 15%; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem a#logoLink {
          width: 100%; }
          #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem a#logoLink .lologo {
            background-image: url("../img/logo.svg");
            background-repeat: no-repeat;
            background-size: cover;
            float: left;
            height: 62px;
            margin-top: 5px;
            width: 100%; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.know-football {
        width: 33%; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.play-predikta-button #play-predikta-button {
        margin: 10px 0;
        top: 0;
        width: auto;
        font-size: 1em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog {
        width: 17%; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog a {
          color: #1888ca;
          text-align: right;
          text-transform: uppercase;
          font-size: 1em;
          text-decoration: underline; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel {
        float: right;
        margin-top: 6px;
        text-align: right;
        width: 14%; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .name-clock-wrapper {
          float: right; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel h1 {
          font-size: 1.2em;
          margin-bottom: 0;
          margin-top: 15px;
          text-transform: uppercase;
          color: #1888CA; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel span {
          color: #1888CA; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group {
          margin-left: 10px;
          float: right;
          margin-top: 2px; }
          #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group button {
            border-radius: 0;
            border: none;
            background-color: transparent; }
          #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .glyphicon-cog:before {
            color: #1799D6;
            font-size: 2.6em; }
          #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .dropdown-menu {
            margin-top: -1px;
            left: -103px; }
          #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group:hover {
            background: #01519e;
            background: -webkit-gradient(linear, left top, left bottom, from(#FF01519E), to(#FF009FE3));
            background: -moz-linear-gradient(center top, #01519e 0%, #009fe3 100%);
            background: -moz-gradient(center top, #01519e 0%, #009fe3 100%);
            background: -webkit-linear-gradient(top, #01519e 0%, #009fe3 100%);
            background: -o-linear-gradient(top, #01519e 0%, #009fe3 100%);
            background: -ms-linear-gradient(top, #01519e 0%, #009fe3 100%);
            background: linear-gradient(to bottom, #01519e 0%, #009fe3 100%);
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#FF01519E', endColorstr='#FF009FE3',GradientType=0 ); }
            #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group:hover .glyphicon-cog:before {
              color: #fff; }
            #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group:hover .dropdown-menu {
              display: block; }
  #dashboard-wrapper #predikta-dashboard {
    width: 98%;
    display: block;
    margin: 0 auto;
    float: none;
    /*  POINTS SECTION -------------------- */
    /*  END POINTS SECTION -------------------- */ }
    #dashboard-wrapper #predikta-dashboard section#points header {
      clear: both;
      display: block;
      float: left;
      width: 100%; }
      #dashboard-wrapper #predikta-dashboard section#points header h1 {
        color: #df1c22;
        text-transform: uppercase;
        font-size: 4em;
        display: inline;
        float: left; }
      #dashboard-wrapper #predikta-dashboard section#points header .leaguedrop {
        background-color: #898989;
        border-radius: 5px;
        height: 40px;
        line-height: 30px;
        overflow: hidden;
        position: relative;
        width: 280px;
        float: right;
        margin-top: 30px; }
        #dashboard-wrapper #predikta-dashboard section#points header .leaguedrop:after {
          background-color: #898989;
          color: #fff;
          content: ">";
          float: right;
          font-size: 24px;
          font-style: normal;
          height: 38px;
          line-height: 30px;
          pointer-events: none;
          position: absolute;
          right: 0;
          text-align: center;
          top: 0;
          transform: rotate(90deg);
          width: 30px; }
        #dashboard-wrapper #predikta-dashboard section#points header .leaguedrop select {
          background: none repeat scroll 0 0 #898989;
          border: 0 solid transparent;
          color: #fff;
          font-size: 1.2em;
          font-weight: 700;
          height: 30px;
          line-height: 30px;
          padding: 0 !important;
          width: 280px;
          cursor: pointer;
          margin-top: 4px; }
    #dashboard-wrapper #predikta-dashboard section#points a.first-time-notification {
      position: absolute;
      top: 14%;
      width: 300px;
      left: 17%; }
      #dashboard-wrapper #predikta-dashboard section#points a.first-time-notification .bluegradinv {
        background: linear-gradient(to bottom, #009fe3 0%, #01519e 100%) repeat scroll 0 0 transparent; }
      #dashboard-wrapper #predikta-dashboard section#points a.first-time-notification .conditional {
        background-clip: padding-box;
        border-radius: 22px;
        box-shadow: 5px 7px 7px rgba(0, 0, 0, 0.6);
        color: #ffffff;
        display: block;
        margin-top: 0;
        padding: 10px 10px 10px 20px;
        position: relative;
        z-index: 99999; }
        #dashboard-wrapper #predikta-dashboard section#points a.first-time-notification .conditional:before {
          border-bottom: 28px solid #009fe3;
          border-left: 12px solid transparent;
          border-right: 12px solid transparent;
          bottom: 79px;
          content: "";
          height: 0;
          left: 59px;
          position: absolute;
          width: 0; }
        #dashboard-wrapper #predikta-dashboard section#points a.first-time-notification .conditional:after {
          background-color: #1888ca;
          border-radius: 14px;
          bottom: 59px;
          box-shadow: 1px 1px 3px 0 rgba(0, 0, 0, 0.5) inset;
          content: "x";
          display: inline-block;
          font-size: 1.4em;
          height: 26px;
          left: 280px;
          line-height: 20px;
          position: absolute;
          text-align: center;
          width: 27px; }
    #dashboard-wrapper #predikta-dashboard section#points .table-responsive {
      clear: both;
      display: block;
      float: left;
      width: 100%; }
      #dashboard-wrapper #predikta-dashboard section#points .table-responsive table {
        border-collapse: collapse;
        border-spacing: 0;
        margin-bottom: 0;
        width: 100%;
        float: left;
        display: block;
        clear: both; }
        #dashboard-wrapper #predikta-dashboard section#points .table-responsive table thead th {
          border-bottom: none; }
        #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tfoot tr td {
          border: medium none;
          padding-left: 0;
          padding-right: 0;
          text-align: center;
          width: 170px; }
        #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tfoot .results td {
          padding-top: 0;
          padding-bottom: 0; }
        #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr {
          display: block;
          clear: both;
          float: left;
          position: relative; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .home-team,
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .away-team {
            min-width: 120px;
            width: 100%; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .home-team {
            text-align: right;
            padding-left: 0; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr th.home-team {
            padding-left: 29px; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .away-team {
            padding-left: 28px;
            padding-right: 0; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr th.away-team {
            min-width: 120px;
            padding-left: 10px; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr th.away {
            padding-left: 25px; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .actual-home,
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .actual-away,
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .client-home,
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .client-away {
            min-width: 20px;
            text-align: center;
            padding-left: 0;
            padding-right: 0; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .actual-home,
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .client-home {
            padding-left: 14px; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state,
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .dash {
            padding-left: 0;
            padding-right: 0; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state {
            padding-left: 25px;
            border-top: none; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state span {
              display: block;
              float: left;
              font-size: 12px;
              line-height: 12px;
              text-align: center;
              width: 40px; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state .time {
              display: block;
              float: left;
              width: 1px;
              font-size: 14px; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state .day {
              clear: both;
              display: block;
              font-size: 14px;
              padding-left: 0;
              text-align: center;
              text-transform: uppercase;
              width: 100%; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .points {
            min-width: 30px;
            text-align: center; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state.bet-in-play {
            padding-left: 3px;
            padding-top: 0;
            padding-bottom: 0; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state.bet-in-play span {
              background: linear-gradient(to bottom, #e7444a 0%, #941913 100%) repeat scroll 0 0 transparent;
              border: 2px solid #1382c4;
              border-radius: 10px;
              color: #ffffff;
              display: block;
              float: left;
              padding: 4px 0;
              position: relative;
              text-transform: uppercase;
              width: 62px;
              padding-bottom: 6px; }
              #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .game-state.bet-in-play span:before {
                border: 2px solid #ffffff;
                border-radius: 6px;
                bottom: 0;
                content: "";
                display: block;
                left: 0;
                position: absolute;
                right: 0;
                top: 0; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .AKKA {
            width: 40px; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .AKKA span {
              border-radius: 20px;
              display: block;
              float: left;
              height: 10px;
              margin-top: 74%;
              width: 10px; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .AKKA .red-circle {
              background-color: #df1a22; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .AKKA .yellow-circle {
              background-color: #fbb03b; }
            #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr .AKKA .green-circle {
              background-color: #39b54a; }
          #dashboard-wrapper #predikta-dashboard section#points .table-responsive table tr td.akka {
            padding-left: 25px;
            padding-right: 25px; }
    #dashboard-wrapper #predikta-dashboard section#points .banker:before {
      border-right: 35px solid transparent;
      border-top: 35px solid #ed1c24;
      content: "";
      display: block;
      height: 0;
      padding-top: 3px;
      position: absolute;
      width: 0; }
    #dashboard-wrapper #predikta-dashboard section#points .banker:after {
      color: #ffffff;
      content: "B";
      font-size: 17px;
      padding: 0 4px 4px;
      position: absolute;
      text-shadow: 1px 1px 1px #000000;
      left: 0;
      top: 0; }
    #dashboard-wrapper #predikta-dashboard section#points #table-banner-add {
      margin-bottom: 20px;
      margin-top: 20px;
      display: block;
      float: left; }
      #dashboard-wrapper #predikta-dashboard section#points #table-banner-add a img {
        width: 100%; }

/*  END Dash board SASS ---------------------- */
/*  My custom styles ---------------------------------  */
/* Predikta Custom Styles ==================================== 
   =========================================================== */
/*  Carosel buttons ------------------------------ */
.carousel-indicators {
  bottom: 5px;
  height: auto;
  left: 0;
  list-style: outside none none;
  position: absolute;
  text-align: center;
  width: 100%;
  z-index: 15;
  padding: 0;
  margin: 0; }
  .carousel-indicators li {
    margin: 0;
    width: 33%;
    height: 50px;
    border-radius: 0;
    height: 89px;
    text-indent: 0; }
  .carousel-indicators .active {
    background-color: rgba(255, 255, 255, 0.7);
    margin: 0;
    width: 33%;
    height: 89px;
    border-radius: 0; }

/*  END Carosel buttons -------------------------- */
.navbar .lologo {
  background-image: url("../img/logo.svg");
  background-repeat: no-repeat;
  float: left;
  height: 62px;
  margin: 2px 0 0 5px;
  width: 100%;
  background-size: cover; }

.logIn,
.signUp {
  margin-top: 10px; }

a#logoLink {
  display: block;
  float: none;
  padding-bottom: 0;
  padding-top: 0;
  margin: 0 auto;
  width: 44%; }

.navbar-inverse .navbar-nav > li > a.social-link {
  color: #1788ca;
  font-family: "typicons";
  font-size: 2.5em;
  font-style: normal;
  font-weight: normal;
  max-width: 50px; }

a.twitter-predikta:before {
  content: '\e0f9';
  /* '' */ }

a.facebook-predikta:before {
  content: "";
  font-size: 1.3em; }

a.linkedin-predikta:before {
  content: ""; }

a.googleplus-predikta:before {
  content: ""; }

a.twitter-predikta,
a.facebook-predikta,
a.linkedin-predikta,
a.googleplus-predikta {
  bottom: 10px;
  position: relative; }

a.googleplus-predikta span,
a.twitter-predikta span,
a.facebook-predikta span,
a.linkedin-predikta span {
  display: block;
  text-indent: -9000px; }

li.socialListItem {
  margin-left: 20px; }

a.twitter-predikta {
  top: 8px; }

a.facebook-predikta {
  top: 12px; }

a.linkedin-predikta {
  top: 6px; }

a.googleplus-predikta {
  font-size: 3em;
  top: 8px; }

ul.nav.navbar-nav {
  width: 100%; }

li#logoListItem {
  width: 50%;
  text-align: center;
  display: inline-block;
  float: left; }

a#logInButton,
a#signUpButton {
  border: 2px solid #1788ca;
  border-radius: 4px;
  color: #1788ca;
  font-size: 1em;
  margin-right: 20px;
  margin-top: 10px;
  padding: 4px 0;
  text-align: center;
  text-transform: uppercase;
  width: 80px; }

ul.caption-list {
  clear: both;
  display: block;
  float: left; }

div.container div.carousel-caption h3,
ul.caption-list li h3 {
  color: #df1c22;
  font-size: 1.6em;
  margin-bottom: 5px;
  margin-top: 0;
  text-transform: uppercase; }

div.boocarousel-caption h3 span,
ul.caption-list li h3 span {
  clear: both;
  color: #1888CA;
  display: block;
  font-size: 1.4em; }

ul.caption-list li p {
  color: #595959;
  font-size: 14px;
  margin: 0 auto;
  width: 70%; }

ul.caption-list li {
  background-color: #ffffff;
  display: inline;
  float: left;
  margin-right: 5%;
  padding-bottom: 10px;
  padding-top: 10px;
  transform: perspective(600px) rotateY(20deg);
  width: 28%; }

ul.caption-list li {
  background-color: #fff;
  display: inline;
  float: left;
  width: 28%;
  padding-top: 10px;
  padding-bottom: 10px;
  margin-right: 5%;
  -webkit-transform: perspective(600px) rotateY(20deg);
  -moz-transform: perspective(600px) rotateY(20deg);
  -ms-transform: perspective(600px) rotateY(20deg);
  -o-transform: perspective(600px) rotateY(20deg);
  transform: perspective(600px) rotateY(20deg);
  -webkit-backface-visibility: hidden;
  -moz-backface-visibility: hidden;
  -ms-backface-visibility: hidden;
  -o-backface-visibility: hidden;
  backface-visibility: hidden; }

.moreOne span:before {
  bottom: 6px;
  color: #1888CA;
  content: "";
  font-size: 4.8em;
  left: 1px;
  position: relative; }
.moreOne span {
  background-color: #fff;
  color: #1888CA;
  display: block;
  font-family: "typicons";
  margin: 0 auto;
  width: 30px;
  height: 30px;
  border-radius: 40px; }

.goTop {
  background-color: transparent;
  display: block;
  float: right;
  padding-bottom: 5px;
  padding-top: 5px;
  position: fixed;
  right: 0;
  text-align: left;
  top: 94%;
  width: 5%;
  position: fixed; }
  .goTop a:before {
    bottom: -20px;
    color: #fff;
    content: "";
    display: block;
    font-size: 3.6em;
    left: 13px;
    position: absolute;
    width: 100%;
    z-index: 99999; }
  .goTop a {
    background-color: rgba(24, 136, 202, 0.7);
    border-radius: 6px;
    display: block;
    font-family: "typicons";
    height: 35px;
    margin: 0 auto;
    position: relative;
    width: 54px;
    z-index: 99999; }

#poolSlide h1 {
  margin-top: 0;
  font-size: 2em; }
#poolSlide h3 span {
  bottom: 15px;
  color: #fff;
  display: block;
  font-size: 1.6em;
  position: relative; }
#poolSlide .btn-primary {
  display: block;
  top: 20px; }
#poolSlide h3 {
  color: #fff;
  display: block;
  font-size: 4.2em;
  font-weight: bold;
  line-height: 1.5em;
  margin-bottom: 0;
  margin-top: 0; }
#poolSlide p {
  bottom: 15px;
  color: #fff;
  display: block;
  font-size: 1.8em;
  line-height: 1;
  margin: 0 auto;
  position: relative;
  width: 30%;
  text-transform: uppercase; }

.pool-size-guarantee {
  background-image: url("../img/red-chevron.png");
  background-size: cover;
  color: #fff;
  display: block;
  float: right;
  font-size: 1.4em;
  height: 24%;
  line-height: 20px;
  position: relative;
  right: 22%;
  text-align: center;
  text-transform: uppercase;
  top: 0;
  width: 10%; }
  .pool-size-guarantee span {
    display: block;
    font-size: 2.2em;
    height: 34px;
    margin-top: 54px; }
  .pool-size-guarantee p {
    display: block;
    margin: 0 auto;
    width: 75%; }

#PrediktaTop nav div.container {
  background-color: #fff; }

h1#about-predikta-heading {
  color: #df1c22;
  font-size: 2.2em;
  margin-bottom: 4%;
  margin-top: 20px;
  text-align: center;
  text-transform: uppercase; }
  h1#about-predikta-heading span {
    color: #1888CA;
    display: block;
    font-size: 1.4em; }

.football-icon:before {
  content: ""; }

.navbar-wrapper {
  background-color: #fff;
  border-bottom: 5px solid #1888CA; }

.carousel-inner {
  float: left;
  height: 100%;
  overflow: hidden;
  position: relative;
  width: 100%; }

.container.marketing {
  padding-left: 0;
  padding-right: 0; }

.container.marketing .row {
  clear: both;
  display: block;
  float: left;
  height: 100%; }

#about-predikta-football {
  clear: both;
  color: #1888ac;
  display: block;
  float: left;
  font-size: 3em;
  text-align: center;
  width: 100%; }

/* TOP Feature row 3 elements ------------------------------  */
#about-predikta-row {
  height: 100vh;
  width: 100vw;
  position: relative; }
  #about-predikta-row #play-predikta-button {
    top: 79%;
    top: 80vh;
    left: 0;
    margin: 0 auto;
    position: absolute;
    right: 0;
    text-align: center;
    width: 200px;
    z-index: 2147483647; }
  #about-predikta-row img {
    max-height: 200px; }
  #about-predikta-row h2 {
    color: #595959;
    font-size: 1.8em;
    font-weight: normal;
    margin: 30px auto 0;
    width: 55%; }

/* END TOP Feature row 3 elements ---------------------------  */
a.predikta-sign-up,
a.have-a-go-next,
a.make-money-next,
a.this-game-next,
a.about-predikta-next,
a.where-predikta-next {
  bottom: 0;
  left: 0;
  margin: 0 auto;
  position: absolute;
  right: 0;
  text-align: center;
  width: 200px;
  z-index: 9999999999; }

.sign-up-wrapper,
.about-predikta-wrapper,
.this-game-wrapper,
.make-money-wrapper,
.have-a-go-wrapper,
.where-predikta-wrapper {
  background-color: transparent;
  border: 2px solid #1799d6;
  clear: both;
  color: #2a57a9;
  display: block;
  font-size: 1.4em;
  height: 44px;
  margin: 0 auto;
  max-width: 244px;
  padding: 6px 22px 0px 20px;
  text-transform: uppercase; }

.about-predikta-wrapper {
  background-color: #000;
  border-width: 3px;
  font-size: 1.6em;
  height: 60px;
  padding: 12px 0 0;
  width: 220px;
  color: #1799D6; }

element.style {
  bottom: 10%; }

.btn.btn-lg.btn-primary {
  font-size: 1.1em; }

.about-predikta-next .arrow-down-2:before {
  bottom: 42px;
  color: #1799D6;
  left: 25px; }

.about-predikta-next .arrow-down-2:after {
  bottom: 46px;
  color: #000;
  right: 13px; }

a.about-predikta-next {
  bottom: 15%;
  z-index: 2147483647;
  width: auto; }

.arrow-down,
.arrow-down-2 {
  clear: both;
  display: block;
  height: 20px;
  margin-top: 0;
  width: 100%; }

.arrow-down:before,
.arrow-down-2:before,
.arrow-down-2:after {
  bottom: 42px;
  color: #df1c22;
  content: "";
  font-family: typicons;
  font-size: 5em;
  height: 0;
  position: relative;
  width: 0; }

.arrow-down-2:before {
  bottom: 42px;
  color: #1799D6;
  left: 17px; }

#play-predikta-button {
  border: 4px solid #1382c4;
  color: #fff;
  text-transform: uppercase;
  background: #e7444a;
  background: -webkit-gradient(linear, left top, left bottom, from(#FFE7444A), to(#FF941913));
  background: -moz-linear-gradient(center top, #e7444a 0%, #941913 100%);
  background: -moz-gradient(center top, #e7444a 0%, #941913 100%);
  background: -webkit-linear-gradient(top, #e7444a 0%, #941913 100%);
  background: -o-linear-gradient(top, #e7444a 0%, #941913 100%);
  background: -ms-linear-gradient(top, #e7444a 0%, #941913 100%);
  background: linear-gradient(to bottom, #e7444a 0%, #941913 100%);
  filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#FFE7444A', endColorstr='#FF941913',GradientType=0 );
  border-radius: 15px;
  clear: both;
  display: block;
  margin: 20px auto 0;
  padding: 12px 16px;
  position: relative;
  text-transform: uppercase;
  width: 215px;
  top: 80px; }

#play-predikta-button:before {
  border: 4px solid #fff;
  border-radius: 10px;
  bottom: 0;
  content: "";
  display: block;
  left: 0;
  position: absolute;
  right: 0;
  top: 0; }

.arrow-down-2:after {
  bottom: 45px;
  right: 21px;
  color: #fff; }

#moreAboutPredikta {
  position: absolute;
  width: 100%; }

#PrediktaTop {
  max-width: 1200px; }

.about-predikta.col-lg-4 {
  clear: none;
  display: inline-block;
  width: 32%; }

.predikta-row.row.featurette,
.predikta-row1.row.featurette,
.predikta-row2.row.featurette {
  position: relative;
  display: block;
  float: left;
  width: 100%; }

/*  ROW ONE Reward Skill Feature section ----------------------  */
.predikta-row1.row.featurette {
  background-repeat: no-repeat;
  background-size: 100% 100%;
  height: 100vh;
  margin: 0;
  padding: 0;
  width: 100vw; }
  .predikta-row1.row.featurette #play-predikta-button {
    top: 79%;
    top: 80vh;
    left: 0;
    margin: 0 auto;
    position: absolute;
    right: 0;
    text-align: center;
    width: 200px;
    z-index: 2147483647; }
  .predikta-row1.row.featurette h1 {
    color: #e31c21;
    float: left;
    font-family: helvetica;
    font-size: 5.4em;
    font-size: 4vw;
    font-weight: bold;
    left: 5%;
    letter-spacing: 0;
    max-height: 140px;
    position: relative;
    text-transform: uppercase;
    -webkit-transform: rotate(-9deg);
    -moz-transform: rotate(-9deg);
    -ms-transform: rotate(-9deg);
    -o-transform: rotate(-9deg);
    transform: rotate(-9deg); }
    .predikta-row1.row.featurette h1 span {
      bottom: 60px;
      clear: both;
      display: inline-block;
      float: left;
      font-size: 1.4em;
      position: relative;
      text-indent: 100px; }
  .predikta-row1.row.featurette .col-md-12 {
    padding-left: 0;
    padding-right: 0;
    position: relative;
    bottom: 26px; }
  .predikta-row1.row.featurette .col-md-9 {
    display: block;
    float: right;
    margin-top: 5%; }
  .predikta-row1.row.featurette .col-md-5 {
    padding-left: 0;
    padding-right: 0;
    bottom: 99px; }
  .predikta-row1.row.featurette img.blue-arrows-both {
    position: relative;
    right: 8%;
    transform: rotate(13deg);
    top: 31px; }
  .predikta-row1.row.featurette img.down-arrows {
    bottom: 51px;
    max-width: 74px;
    position: relative;
    transform: rotate(6deg); }
  .predikta-row1.row.featurette img.arrow-copy {
    bottom: 172px;
    bottom: 22vh;
    display: inline;
    float: right;
    max-width: 440px;
    position: relative;
    right: 26%; }

/*  END ROW ONE Reward Skill Feature section ------------------  */
/*  ROW TWO HAVE A GO Feature section -------------------------  */
.predikta-row2.row.featurette {
  height: 100vh;
  width: 100vw;
  background-size: 100% 100%;
  position: relative; }
  .predikta-row2.row.featurette #play-predikta-button {
    top: 79%;
    top: 80vh;
    left: 0;
    margin: 0 auto;
    position: absolute;
    right: 0;
    text-align: center;
    width: 200px;
    z-index: 2147483647; }
  .predikta-row2.row.featurette h1 {
    color: #1799D6;
    display: block;
    font-family: helvetica;
    font-size: 9em;
    font-size: 6.5vw;
    font-weight: bold;
    letter-spacing: 0;
    line-height: 0.8em;
    margin-top: 66px;
    position: relative;
    right: 4%;
    text-transform: uppercase;
    transform: scale(0.9, 1.2);
    width: 100%; }
  .predikta-row2.row.featurette h2 {
    background-image: url("../img/hand.png");
    background-position: 100% 100%;
    background-repeat: no-repeat;
    color: #ec1c22;
    display: inline-block;
    float: right;
    font-size: 3.6em;
    padding-bottom: 34px;
    padding-right: 152px;
    padding-top: 96px;
    position: absolute;
    right: 86px;
    text-transform: uppercase;
    top: 107px;
    transform: rotate(-9deg); }
  .predikta-row2.row.featurette h3 {
    background-image: url("../img/target.png");
    background-position: 99% 78px;
    background-repeat: no-repeat;
    background-size: 33% auto;
    bottom: 10%;
    bottom: 10vh;
    color: #838383;
    float: right;
    font-size: 4em;
    margin-top: 0;
    padding-bottom: 137px;
    padding-top: 10%;
    position: relative;
    text-transform: uppercase;
    transform: rotate(17deg);
    width: 57%; }
    .predikta-row2.row.featurette h3 .lead {
      color: #838383;
      display: block;
      font-size: 1.9vw;
      height: 30px;
      margin: 0;
      padding: 0;
      position: relative; }
    .predikta-row2.row.featurette h3:after {
      bottom: 100px;
      clear: none;
      color: #898989;
      content: "";
      display: inline;
      font-family: "Glyphicons Halflings";
      font-size: 2.5em;
      position: absolute;
      right: 300px; }

/*  END ROW TWO  HAVE A GO Feature section --------------------  */
/*  Feature row THREE make money ------------------------------  */
.predikta-row3.row.featurette {
  height: 100vh;
  width: 100vw;
  background-size: 100% 100%;
  position: relative; }
  .predikta-row3.row.featurette #play-predikta-button {
    top: 79%;
    top: 80vh;
    left: 0;
    margin: 0 auto;
    position: absolute;
    right: 0;
    text-align: center;
    width: 200px;
    z-index: 2147483647; }
  .predikta-row3.row.featurette h1 {
    color: #1996d3;
    font-size: 8.2em;
    margin-top: 3.5%;
    text-align: center;
    text-transform: uppercase; }
  .predikta-row3.row.featurette h2 {
    color: #898989;
    font-size: 4.2em;
    text-align: center;
    text-transform: uppercase;
    margin-top: 0; }
  .predikta-row3.row.featurette img.prize-cup,
  .predikta-row3.row.featurette img.dollar-bill {
    display: block;
    margin: 0 auto; }
  .predikta-row3.row.featurette img.dollar-bill {
    width: 8%; }
  .predikta-row3.row.featurette img.prize-cup {
    width: 9%; }
  .predikta-row3.row.featurette .star-icon:before {
    color: #898989;
    content: "";
    display: block;
    float: none;
    font-family: Typicons;
    font-size: 4.2em;
    margin: 9px auto 0;
    text-align: center;
    height: 64px; }

/*  END Feature row THREE make money --------------------------  */
/*  Feature row FOUR this game --------------------------------  */
.predikta-row4.row.featurette {
  height: 92vh;
  width: 100vw;
  background-size: 100% 100%;
  position: relative; }
  .predikta-row4.row.featurette #play-predikta-button {
    top: 74%;
    top: 75vh;
    left: 0;
    margin: 0 auto;
    position: absolute;
    right: 0;
    text-align: center;
    width: 200px;
    z-index: 2147483647; }
  .predikta-row4.row.featurette .col-md-6 {
    display: block;
    float: left;
    padding-top: 35px; }
    .predikta-row4.row.featurette .col-md-6 ul {
      height: 50px;
      left: 12%;
      position: relative;
      top: 15%;
      transform: rotate(-14deg); }
      .predikta-row4.row.featurette .col-md-6 ul li {
        height: 35px;
        list-style: outside none none; }
        .predikta-row4.row.featurette .col-md-6 ul li:nth-child(2) {
          padding-left: 60px; }
        .predikta-row4.row.featurette .col-md-6 ul li:nth-child(3) {
          padding-left: 120px; }
        .predikta-row4.row.featurette .col-md-6 ul li:nth-child(4) {
          padding-left: 180px; }
        .predikta-row4.row.featurette .col-md-6 ul li img {
          max-width: 245px;
          float: left; }
        .predikta-row4.row.featurette .col-md-6 ul li h2 {
          bottom: 8px;
          color: #1888ca;
          font-size: 3.2em;
          left: 5px;
          position: relative;
          text-transform: uppercase; }
  .predikta-row4.row.featurette #next-week-predikta {
    padding-top: 89px; }
    .predikta-row4.row.featurette #next-week-predikta h3 {
      color: #df1c22;
      font-size: 2.2em;
      right: 6%;
      position: relative;
      text-transform: uppercase;
      transform: rotate(-14deg); }
      .predikta-row4.row.featurette #next-week-predikta h3 span {
        display: block;
        margin-left: 26%; }
  .predikta-row4.row.featurette #predikta-certainty h2 {
    color: #1888CA;
    font-size: 3em;
    margin-bottom: 0;
    margin-top: 47px;
    text-align: center;
    text-transform: uppercase; }
  .predikta-row4.row.featurette #predikta-certainty h1 {
    color: #1888CA;
    font-size: 8em;
    line-height: 55px;
    margin-top: 11px;
    text-align: center;
    text-transform: uppercase;
    margin-bottom: 0; }
  .predikta-row4.row.featurette #predikta-certainty p {
    color: #1888ca;
    display: block;
    font-size: 1.4em;
    line-height: 24px;
    margin-left: auto;
    margin-right: auto;
    margin-top: 28px;
    text-align: center;
    text-transform: uppercase;
    width: 37%; }
  .predikta-row4.row.featurette .btn-primary {
    top: 10px; }

/*  END Feature row FOUR this game ----------------------------  */
/*  FOOTER ----------------------------------------------------  */
footer {
  background-color: #000000;
  display: block;
  float: left;
  width: 100%; }
  footer ul {
    display: block;
    margin: 0 auto;
    max-width: 1330px; }
    footer ul li {
      display: inline;
      float: left;
      list-style: outside none none;
      width: auto; }
      footer ul li a {
        text-transform: uppercase;
        color: #fff;
        text-decoration: underline;
        font-style: italic;
        width: 100%;
        display: block;
        float: left;
        margin-left: 15px; }
        footer ul li a img {
          display: block;
          float: left;
          width: 100%; }
    footer ul li.opta-logo {
      margin-right: 8%; }
      footer ul li.opta-logo a img {
        max-width: 70px;
        max-height: 30px; }
    footer ul li.ladbrokes-logo {
      margin-right: 10%; }
      footer ul li.ladbrokes-logo a img {
        max-width: 106px; }
    footer ul li.stakes-ladders {
      margin-left: 11%; }
      footer ul li.stakes-ladders a img {
        max-width: 169px; }
    footer ul li.age-rating {
      position: absolute;
      right: 15px; }
      footer ul li.age-rating a img {
        max-width: 40px; }
  footer p.footer-predikta-info {
    display: block;
    width: 100%;
    clear: both;
    float: left;
    text-align: center; }

/*  END FOOTER ------------------------------------------------  */
/* ===================================================
   END Predikta custom styles
   =================================================== */
/*  MAX WIDTH 1200PX --------------------------------- */
@media screen and (max-width: 1200px) {
  #dashboard-wrapper {
    /*  Header ------------------------------- */
    /*  END Header --------------------------- */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li h3 {
      font-size: 1.4em;
      margin-right: 0; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem a#logoLink .lologo {
      background-position: 160% 100%;
      width: 160px;
      height: 50px;
      margin-top: 10px;
      margin-left: 0; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.play-predikta-button #play-predikta-button {
      margin-top: 10px;
      padding: 9px 16px;
      transform: scale(0.9, 1);
      -webkit-transform: scale(0.9, 1);
      /* Safari and Chrome */
      -moz-transform: scale(0.9, 1);
      /* Firefox */
      -ms-transform: scale(0.9, 1);
      /* IE 9+ */
      -o-transform: scale(0.9, 1);
      /* Opera */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog {
      width: 15%; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog a {
        font-size: 0.9em;
        line-height: 16px;
        padding-left: 0;
        padding-right: 0;
        transform: scale(0.8, 1);
        -webkit-transform: scale(0.8, 1);
        /* Safari and Chrome */
        -moz-transform: scale(0.8, 1);
        /* Firefox */
        -ms-transform: scale(0.8, 1);
        /* IE 9+ */
        -o-transform: scale(0.8, 1);
        /* Opera */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel {
      margin-top: 0; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel h1 {
        font-size: 1em;
        margin-top: 11px; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group button {
        padding: 5px; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .glyphicon-cog:before {
        font-size: 2.4em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .dropdown-menu {
        left: -128px; } }
/*  END MAX WIDTH 1200PX ----------------------------- */
/*  MAX WIDTH 1024PX --------------------------------- */
@media screen and (max-width: 1024px) {
  #dashboard-wrapper {
    /*  Header -------------------------------------------- */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li h3 {
      width: 234px;
      font-size: 1.1em;
      transform: scale(0.7, 1);
      -webkit-transform: scale(0.7, 1);
      /* Safari and Chrome */
      -moz-transform: scale(0.7, 1);
      /* Firefox */
      -ms-transform: scale(0.7, 1);
      /* IE 9+ */
      -o-transform: scale(0.7, 1);
      /* Opera */
      margin-top: 5px;
      position: relative;
      left: 10%; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem a#logoLink .lologo {
      width: 150px;
      height: 47px;
      margin-top: 0; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.know-football {
      width: 33%; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.play-predikta-button #play-predikta-button {
      border-radius: 6px;
      border-width: 2px;
      margin-top: 3px;
      padding: 5px 11px;
      transform: scale(0.8, 1);
      -webkit-transform: scale(0.8, 1);
      /* Safari and Chrome */
      -moz-transform: scale(0.8, 1);
      /* Firefox */
      -ms-transform: scale(0.8, 1);
      /* IE 9+ */
      -o-transform: scale(0.8, 1);
      /* Opera */
      font-size: 0.8em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.play-predikta-button #play-predikta-button:before {
        border-width: 2px;
        border-radius: 6px; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog {
      width: 12%; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog a {
        font-size: 0.8em;
        line-height: 14px;
        padding-left: 0;
        padding-right: 0;
        padding-top: 5px;
        transform: scale(0.8, 1);
        -webkit-transform: scale(0.8, 1);
        /* Safari and Chrome */
        -moz-transform: scale(0.8, 1);
        /* Firefox */
        -ms-transform: scale(0.8, 1);
        /* IE 9+ */
        -o-transform: scale(0.8, 1);
        /* Opera */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel {
      margin-top: 0; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .name-clock-wrapper {
        font-size: 0.8em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel h1 {
        font-size: 1em;
        margin-top: 11px; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group button {
        padding: 3px; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .glyphicon-cog:before {
        font-size: 2em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .dropdown-menu {
        left: -128px; }

  /*  END Header ---------------------------------------- */ }
/*  END  MAX WIDTH 1024PX ---------------------------- */
/*  MAX WIDTH 767PX ---------------------------------- */
@media screen and (max-width: 767px) {
  #dashboard-wrapper {
    /*  Header -------------------------------------------- */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li h3 {
      width: 234px;
      font-size: 1.1em;
      transform: scale(0.7, 1);
      -webkit-transform: scale(0.7, 1);
      /* Safari and Chrome */
      -moz-transform: scale(0.7, 1);
      /* Firefox */
      -ms-transform: scale(0.7, 1);
      /* IE 9+ */
      -o-transform: scale(0.7, 1);
      /* Opera */
      margin-top: 5px;
      position: relative;
      left: 10%; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem {
      display: block;
      float: left;
      width: 100%; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem a#logoLink {
        display: block;
        float: left;
        padding: 0;
        position: relative;
        width: 100%;
        z-index: 99999; }
        #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li#logoListItem a#logoLink .lologo {
          width: 150px;
          height: 47px;
          margin-top: 0; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.know-football {
      width: 33%; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.play-predikta-button #play-predikta-button {
      border-radius: 6px;
      border-width: 2px;
      margin-top: 3px;
      padding: 5px 11px;
      transform: scale(0.8, 1);
      -webkit-transform: scale(0.8, 1);
      /* Safari and Chrome */
      -moz-transform: scale(0.8, 1);
      /* Firefox */
      -ms-transform: scale(0.8, 1);
      /* IE 9+ */
      -o-transform: scale(0.8, 1);
      /* Opera */
      font-size: 0.8em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.play-predikta-button #play-predikta-button:before {
        border-width: 2px;
        border-radius: 6px; }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog {
      width: 12%; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.read-predikta-blog a {
        font-size: 0.8em;
        line-height: 14px;
        padding-left: 0;
        padding-right: 0;
        padding-top: 5px;
        transform: scale(0.8, 1);
        -webkit-transform: scale(0.8, 1);
        /* Safari and Chrome */
        -moz-transform: scale(0.8, 1);
        /* Firefox */
        -ms-transform: scale(0.8, 1);
        /* IE 9+ */
        -o-transform: scale(0.8, 1);
        /* Opera */ }
    #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel {
      margin-top: 0; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .name-clock-wrapper {
        font-size: 0.8em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel h1 {
        font-size: 1em;
        margin-top: 11px; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group button {
        padding: 3px; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .glyphicon-cog:before {
        font-size: 2em; }
      #dashboard-wrapper .navbar-wrapper #PrediktaTop .container ul li.admin-panel .btn-group .dropdown-menu {
        left: -128px; }

  /*  END Header ---------------------------------------- */ }
/*  END  MAX WIDTH 767PX ----------------------------- */

/*# sourceMappingURL=style.cs.map */
