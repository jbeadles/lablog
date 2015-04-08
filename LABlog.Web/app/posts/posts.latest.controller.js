var app;
(function (app) {
    var posts;
    (function (posts) {
        var latest;
        (function (latest) {
            "use strict";
            var LatestPostsController = (function () {
                function LatestPostsController() {
                }
                return LatestPostsController;
            })();
        })(latest = posts.latest || (posts.latest = {}));
    })(posts = app.posts || (app.posts = {}));
})(app || (app = {}));
//# sourceMappingURL=posts.latest.controller.js.map