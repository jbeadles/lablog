((): void => {
    "use strict";

    angular
        .module("app.posts")
        .config(config);

    config.$inject = ["$stateProvider", "$urlRouterProvider"];

    
    var config = ($stateProvider: angular.ui.IStateProvider, $urlRouterProvider: angular.ui.IUrlRouterProvider): void => {

        $urlRouterProvider.otherwise("/posts");

        $stateProvider

        // HOME STATES AND NESTED VIEWS =====================================
            .state("posts", {
                url: "/posts",
            templateUrl: "posts.html"
            });

    };
})();