/// <binding BeforeBuild='sass' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var sass = require("gulp-sass");

var paths = {
    webroot: "./wwwroot/"
};


paths.sassSource = "./Scss/*.scss";
paths.bower_components = paths.webroot + "lib/";
paths.cssOutput = paths.webroot + "css/";

gulp.task('sass', function () {
    gulp.src(paths.sassSource)
        .pipe(sass({
            includePaths: [
                paths.bower_components + 'foundation-sites/scss'
            ]
        }).on('error', sass.logError))
        .pipe(gulp.dest(paths.cssOutput));
})


gulp.task('default', function () {
    // place code for your default task here
});