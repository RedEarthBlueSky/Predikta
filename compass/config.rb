# Require any additional compass plugins here.

#Folder settings
relative_assets = true      #because we're not working from the root
css_dir = "../css"          #where the CSS will saved
sass_dir = "sass"           #where our .scss files are
images_dir = "../images"    #the folder with your images
javascript_dir = "../js"    #folder where js files are
fonts_dir = "../fonts"      #folder where font files are


# You can select your preferred output style here (can be overridden via the command line):
output_style = :expanded # After dev :compressed

# In development, we can turn on the FireCompass-compatible debug_info.
#firecompass = false
firecompass = true

# To disable debugging comments that display the original location of your selectors. Uncomment:
line_comments = true

# Obviously
preferred_syntax = :scss

# Pass options to sass. For development, we turn on the FireCompass-compatible
# line_comments if the firecompass config variable above is true.
sass_options = {:debug_info => true}













