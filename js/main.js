

$(document).ready(function () {

/*  detect the window height and set the players element to it */
    function setHeight() {
      windowHeight = ($(window).innerHeight() - 300);
      $('#players').css('max-height', windowHeight);
    };
    setHeight();

    $(window).resize(function () {
      setHeight();
    });
/*
    function setDivWidth() {
      var first = $("[data-parent=\"#players\"]").first();
      var value = first.find("span.points").text();
      var width = first.width();
      var increments = width / value;

      $("[data-parent=\"#players\"]").each(function () {
        var points = $(this).find("span.points").text();
        var divWidth = points * increments;
        $(this).animate({ width: divWidth }, 1000);
      });
    }
    setDivWidth();
*/



  $(function () {
//  need to add an ajax element here to hold the function state
      $(".first-time-notification").on('click', function () {
        $(this).addClass("no-display");
      });
 });
  //  Initialize jScrollPane 
  //$(function () {
  //  $('.table-responsive').jScrollPane();
 // });




/*  provie a smooth transition between links in the same page 
  $('a[href*=#]:not([href=#])').click(function () {
    if (location.pathname.replace(/^\//, '') == this.pathname.replace(/^\//, '') || location.hostname == this.hostname) {
      var id = this.id;
      var target = $(this.hash);
      target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');
      if (target.length) {
        $('html,body').animate({
          scrollTop: target.offset().top
        }, 1000);
        return false;
      }
    }
  });
*/
/*  Update the clock using moment.js -----------------  */
  $(function () {
    updateClock();
    setInterval(updateClock, 1000);
    function updateClock() {
      var gmtOffset = 0;
      var time = moment.utc().add("hours", gmtOffset).format("hh:mm:ss");
      $('#clock').html(time);
    }
  });


});

