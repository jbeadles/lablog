((): void => {
    "use strict";

    angular
        .module("app", [
        /*
         * Shared modules
         */
            "app.core",
            "app.layout",
            "app.services",
        /*
         * Feature areas
         */
            "app.admin",
            "app.categories",
            "app.posts",
            "app.sidebar"
        ]);
})();