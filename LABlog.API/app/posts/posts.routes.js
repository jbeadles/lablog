(function () {
    "use strict";
    angular.module("app.posts").config(config);
    config.$inject = ["$stateProvider", "$urlRouterProvider"];
    var config = function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise("/posts");
        $stateProvider.state("posts", {
            url: "/posts",
            templateUrl: "posts.html"
        });
    };
})();
//# sourceMappingURL=posts.routes.js.map