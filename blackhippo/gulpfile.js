var gulp = require('gulp');
var sass = require('gulp-sass');
var uglify = require('gulp-uglify');
var rename = require('gulp-rename');
var cssmin = require('gulp-cssmin');
var del = require('del');

gulp.task('compileSass', function() {
    gulp.src('wwwroot/css/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest('wwwroot/css/'))
});

gulp.task("minifyCss", ["compileSass"], function() {
    return gulp.src("wwwroot/css/site.css")
      .pipe(cssmin())
      .pipe(rename('site.min.css'))
      .pipe(gulp.dest('wwwroot/css/'));
});

gulp.task("minifyScripts", function() {
    return gulp.src("wwwroot/js/site.js")
      .pipe(uglify())
      .pipe(rename('site.min.js'))
      .pipe(gulp.dest('wwwroot/js/'));
});

gulp.task('clean', function() {
    del(['wwwroot/css/site.css', 'wwwroot/css/site.min.css', 'wwwroot/js/site.min.js*']);
});

gulp.task('cleanCss', function() {
    del(['wwwroot/css/site.css', 'wwwroot/css/site.min.css']);
});

gulp.task('cleanJs', function(){
    del(['wwwroot/js/site.min.js*']);
})

gulp.task("build", ['minifyScripts', 'minifyCss'], function() {
});

gulp.task('watch', function() {
    gulp.watch('wwwroot/css/*.scss', ['cleanCss', 'minifyCss']);
    gulp.watch('wwwroot/js/*.js', ['cleanJs', 'minifyScripts']);
});
//Watch task
gulp.task('default', ['clean', 'build']);