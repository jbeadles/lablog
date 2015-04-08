(function () {
    "use strict";
    angular.module("app.posts").config(config);
    config.$inject = ["$stateProvider", "$urlRouterProvider"];
    function config($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise("/");
        $stateProvider.state("posts", {
            url: "/posts",
            templateUrl: "app/posts/posts.published.html",
            controller: "PostsPublishedController",
            controllerAs: "posts"
        }).state("post", {
            url: "/posts/:id",
            templateUrl: "app/posts/post.single.html",
            controller: "PostSingleController",
            controllerAs: "post"
        });
    }
    ;
})();
//# sourceMappingURL=posts.routes.js.map