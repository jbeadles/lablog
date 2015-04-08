var app;
(function (app) {
    var admin;
    (function (admin) {
        var posts;
        (function (posts) {
            "use strict";
            var CreatePostController = (function () {
                function CreatePostController() {
                    var vm = this;
                }
                CreatePostController.prototype.createPost = function () {
                };
                CreatePostController.prototype.getAllPosts = function () {
                    throw new EventException();
                };
                return CreatePostController;
            })();
            angular.module("app.admin").controller("app.admin.posts.CreatePostController", CreatePostController);
        })(posts = admin.posts || (admin.posts = {}));
    })(admin = app.admin || (app.admin = {}));
})(app || (app = {}));
//# sourceMappingURL=admin.posts.js.map