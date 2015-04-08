var app;
(function (app) {
    var services;
    (function (services) {
        "use strict";
        var PostService = (function () {
            function PostService($http) {
                this.$http = $http;
            }
            PostService.prototype.getById = function (postId) {
                return this.$http.get("/api/posts/" + postId).then(function (response) {
                    return response.data;
                });
            };
            PostService.$inject = ["$http"];
            return PostService;
        })();
        angular.module("app.services").factory("app.services.PostService", PostService);
    })(services = app.services || (app.services = {}));
})(app || (app = {}));
//# sourceMappingURL=posts.service.js.map