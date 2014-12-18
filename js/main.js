
$(document).ready(function () {

  var varbs = {
    buttonGroup:    "aside#bets #banter .new-post-wrapper .btn-group",
    eb: "#emailBanter",
    newPostButton: '.player-wrapper button',
    emailInput: '<input type="email" value="email address" class="player-email" onfocus="this.value = \'\'\" onblur="this.value = \'email address\'\" />'
  }

  $('.add-more').on('click', function () {
    $('form.email-invite > .input-wrapper').append(varbs.emailInput);
  });
  
  /*  get the player name from the edit player details list and drop it into the cancel confirmation screen */
  $('.edit-player-wrapper .edit-player').click(function (event) {
    event.preventDefault();
    var player_name = $(this).text();
    $('.remove-player').click(function (e) {
        e.preventDefault();
        $('span.name').text(player_name);
    });
  });


  /*  bring up remove player confirmation panel */
  $('.confirmation-screen').hide();
  $('.remove-player').click(function () {
    $('.confirmation-screen').slideToggle();
  });
  $('button.cancel').click(function () {
    $('.confirmation-screen').hide();
  });
  

/*  In edit league panel on the league masters dashboard put the selected league name in the h1 header */
  $('#edit-league .player-wrapper').click(function () {
    var league = $(this).find('.name').text();
    $('#edit-league .player-wrapper').css('background-color', '#ececec');
    $(this).css('background-color', '#c2c2c2');
    $('#edit-league h1').text("Edit " + league + " League");
    if (!$('#edit-league .dropdown-button').text().indexOf("Select league to edit")) {
      $('#edit-league .dropdown-button').html("Edit another league <span class=\"up-arrow\">></span>");
    } 
  });

  $('#master-dashboard #invite-players .dropdown-button').on('click', function () {

    $('.new-players-wrapper').slideToggle();

  });

/*  At mobile width provide slider for points element */
  function togglePoints() {
    width = $(window).width();  
    if (width < 768)
    {
      /*  add the id and class identifiers we need to continue */
      $('section#points header h1').attr('id', 'points-header').addClass('minus');
    }
      /*  remove the id and class identifiers when we leave mobile width -- making sure to check they are there at all */
    else if (width >= 768 && ($('section#points header h1').hasClass()))
    {
      $('section#points header h1').removeClass().removeAttr('id');  
    }
    /*  here is our functionality, but it only works if the class and id have been added to the h1 element */
    /*  added unbind to overcome bug of click executing twice */
    $('#points-header').unbind('click').on('click', function () {
      $('.leaguedrop, #box-wrapper').slideToggle(500);
        if ($('#points-header').hasClass('minus'))
        {
          $('#points-header').attr('class', 'plus').animate({ 'width': '100%' }, 250);
        }
        else if ($('#points-header').hasClass('plus'))
        {
          $('#points-header').attr('class', 'minus').animate({ 'width': '40%' }, 250);
        }
    });
  }
  togglePoints();

  /*  make the arrow in the league dashboard page change flip up and down */
  function downArrow(target) {
    $(target).on('click', function () {
      if ($(this).find('span').hasClass('up-arrow')) {
        $(this).find('span').removeClass('up-arrow').addClass('down-arrow');
      }
      else if ($(this).find('span').hasClass('down-arrow')) {
        $(this).find('span').removeClass('down-arrow').addClass('up-arrow');
      }
        /*  if we have a pencil rather than an arrow toggle this with an 'x' */
      else if ($(this).find('span').hasClass('pencil')) {
        $(this).find('span').removeClass('pencil').addClass('close-this');
      }
      else if ($(this).find('span').hasClass('close-this')) {
        $(this).find('span').removeClass('close-this').addClass('pencil');
      }
      /*  uncheck names if we close the panel */
      $("input[id*='emailSlacker']").prop('checked', false);
    });
  }
  downArrow('.dropdown-button');
  if ($(window).width() < 641) {
    $('.new-post-wrapper, .existing-league-wrapper, .new-players-wrapper').hide();
    $('#auto-banter-header').unbind().on('click', function () {
      $('.new-post-wrapper').slideToggle();
      $('textarea').focus();
    });
    $('#invite-players-header').unbind().on('click', function () {
      $('.existing-league-wrapper, .new-players-wrapper').slideToggle();
    });
    $('#existing-players h1').unbind().on('click', function () {
      $('.edit-player-wrapper').slideToggle();
    });
    downArrow('#auto-banter-header');
    downArrow('#invite-players-header');
    downArrow('#existing-players h1');

  }

  $(window).resize(function(){
    if ($(window).width() < 641) {
      $('.new-post-wrapper, .existing-league-wrapper, .new-players-wrapper, .edit-player-wrapper').hide();
      $('#auto-banter-header').unbind().on('click', function () {
        $('.new-post-wrapper').slideToggle();
      });
      $('#invite-players-header').unbind().on('click', function () {
        $('.existing-league-wrapper, .new-players-wrapper').slideToggle();
      });
      $('#existing-players h1').unbind().on('click', function () {
        $('.edit-player-wrapper').slideToggle();
      });
      downArrow('#auto-banter-header');
      downArrow('#invite-players-header');
      downArrow('#existing-players h1');
    }
    else if ($(window).width() > 640) {
      $('.new-post-wrapper, .edit-player-wrapper').show();
      $('.existing-league-wrapper, .new-players-wrapper').show();
    }
  });


/*  move the banner add when we get to below iPad landscape */
  function moveStuff() {
    width = $(window).width();
    if (width <= 1016 && (($("#points #table-banner-add").length) > 0)) {
      $("#table-banner-add").appendTo("#bets-table-wrapper");
    }
    else if (width > 1016 && (($("#bets-table-wrapper #table-banner-add").length) > 0)) {
      $("#table-banner-add").appendTo("#points");
    }
  }

  $(".modal").on("show", function () {
    $("body").addClass("modal-open");
  }).on("hidden", function () {
    $("body").removeClass("modal-open")
  });

/*  functionality of the 'new post' button when clicked */
  $(varbs.newPostButton).click(function () {
    $('#bets h1, #bets table, #commets-wrapper').slideToggle(function () {
      $('#comments-wrapper').hide();
    });
    /* hide the button group as this will not work on the document load */
    $(varbs.buttonGroup).hide();
    /*  make sure the check box is not checked */
    $(varbs.eb).prop('checked', false);
    /*  change the text so it is clear this is also the button to close the element */
    if ($(this).text() == "New Post") {
      $(this).text("Close this Post");
    }
    else {
      $(this).text("New Post");
    }; 
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

  /*  Configuration for the multiselect plugin */
  $('#player-banter-list').multiselect({
    includeSelectAllOption: true,
    selectAllText: 'SELECT ALL PLAYERS!',
    nonSelectedText: 'Players to banter',
    allSelectedText: 'All players selected',
    maxHeight: 200
  });





  /*  switch panel content to specific week on select drop down */
  $("select#scoreRounds").change(function () {
    var value = $("select#scoreRounds option:selected").attr("value");
    value = "." + value;
    $("#box-wrapper div[class^=\"week\"]").hide();


    $(value).show(5000);

  }).change();
  




  /*  switch panel content to specific league on select drop down */
  $("select#banterLeague").change(function () {
    var value = $("select#banterLeague option:selected").attr("value");
    value = "." + value;
    $("#banterWrapper div[class^=\"league\"]").hide();
    $(value).show(500);
  }).change();



/*  detect the window and viewport height and set the players element, and modal body to it */
  function setHeight() {
    var width = $(window).width();
        /*  this only works for iPad portrait view and above so remove if this is the case  */
        if (width >= 1023) {
          windowHeight = ($(window).innerHeight() - 400);
          viewportHeight = ($("body").innerHeight()-295);
          $('.modal-body').css("height", viewportHeight);
          $('#players').css('max-height', windowHeight);
        }
        else {
          windowHeight = ($(window).innerHeight() - 400);
          $('#players').css('max-height', windowHeight);
          $('.modal-body').css("height", "463");
        }
    };


    setHeight();
    moveStuff();
    $(window).resize(function () {
      setHeight();
      moveStuff();
      togglePoints();
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


  /*  remove the need for moment.js with simple time function ------ */
  Number.prototype.zeroPad = function (length) {
    length = length || 2; // defaults to 2 if no parameter is passed
    return (new Array(length).join('0') + this).slice(length * -1);
  };

  function date() {
    var now = new Date(),
        now = now.getHours() + ':' + now.getMinutes().zeroPad();
    $('#clock').html(now);
  }
  setInterval(function(){date()}, 1000);

});

