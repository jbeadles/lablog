(function () {
    "use strict";
    angular.module("app").config(config);
    config.$inject = ["$locationProvider"];
    var config = function ($locationProvider) {
        $locationProvider.html5Mode(true);
    };
})();
//# sourceMappingURL=app.config.js.map