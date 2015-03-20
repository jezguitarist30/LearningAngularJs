(function() {
    'use strict';


    var homeCtrl = function($scope) {

        this.pageName = "This is my Home Page";

        this.user = {
            name: "Jez Reel"
        };

        this.post = "";

        this.posts = [
            { post: 'Hi This is my first Post', user: { name: 'Jez Reel' } },
            { post: 'Hi This is my second Post', user: { name: 'John Doe' } }
        ];

        this.submitPost = function () {

            
            this.posts.push({ post: this.post,  user: {name: this.user.name }});
          
        };

    };


    angular.module('myApp').controller('homeCtrl', [
        '$scope', homeCtrl
    ]);

})();