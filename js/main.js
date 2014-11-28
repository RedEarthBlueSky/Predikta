

$(document).ready(function () {

  /*  hide and show the comments panel upon the creation of a new post */
  var varbs = {
    buttonGroup:    "aside#bets #banter .new-post-wrapper .btn-group",
    eb: "#emailBanter",
    newPostButton: '.player-wrapper button'
  }

  $(varbs.newPostButton).click(function () {
    $('#bets h1, #bets table, #commets-wrapper').slideToggle();
    /* hide the button group as this will not work on the document load */
    $(varbs.buttonGroup).hide();
    /*  make sure the check box is not checked */
    $(varbs.eb).prop('checked', false);
  });

  /*  hide the email list and display it when the checkbox is selected */
  $('#emailBanter').on('change', (function () {
    if ($(this).is(':checked')) {
      $(varbs.buttonGroup).show("500");
    } else {
      $(varbs.buttonGroup).hide("500");
      /*  clear all selections from the list */
      $('#player-email-list').multiselect("clearSelection");
    }
  }));


/*  Configuration for the multiselect plugin */
  $('#player-email-list').multiselect({
    includeSelectAllOption: true,
    selectAllText: 'SELECT ALL PLAYERS!',
    nonSelectedText: 'Select players to email banter',
    allSelectedText: 'All players selected',
    maxHeight: 200
  });

  /*  switch panel content to specific week on select drop down */
  $("select#scoreRounds").change(function () {
    var value = $("select#scoreRounds option:selected").attr("value");
    value = "." + value;
    $("#box-wrapper div[class^=\"week\"]").hide();
    $(value).show(500);
  }).change();
  
  /*  switch panel content to specific league on select drop down */
  $("select#banterLeague").change(function () {
    var value = $("select#banterLeague option:selected").attr("value");
    value = "." + value;
    $("#banterWrapper div[class^=\"league\"]").hide();
    $(value).show(500);
  }).change();



/*  detect the window height and set the players element to it */
    function setHeight() {
      windowHeight = ($(window).innerHeight() - 400);
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

