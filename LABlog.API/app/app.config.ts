((): void => {
    "use strict";

    angular
        .module("app")
        .config(config);

    config.$inject = ["$locationProvider"];

    var config = ($locationProvider: ng.ILocationProvider): void => {

        $locationProvider.html5Mode(true);

    };

})(); 