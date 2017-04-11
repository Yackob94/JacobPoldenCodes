module.exports = function (grunt) {
    grunt.initConfig({
        copy: {
            js: {
                expand: true,
                cwd: './node_modules',
                dest: './Content/Scripts/',
                flatten: true,
                filter: 'isFile',
                src: [
                    './bootstrap/dist/js/bootstrap.js',
                    './jquery/dist/jquery.js'
                ]
            },
            css: {
                expand: true,
                cwd: './node_modules',
                dest: './Content/Css/',
                flatten: true,
                filter: 'isFile',
                src: [
                    './bootstrap/dist/css/bootstrap.css'
                ]
            }
        },
        watch: {
            dist: {
                files: [
                    './node_modules/bootstrap/dist/css/bootstrap.css',
                    './node_modules/bootstrap/dist/js/bootstrap.js',
                    './node_modules/jquery/dist/jquery.js'
                ],
                tasks: ['default'],
                options: {
                    spawn: false
                }
            }
        }
    });
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-copy');

    grunt.registerTask('default', ['copy']);
};