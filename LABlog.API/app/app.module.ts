((): void => {
    "use strict";

    angular
        .module("app", [
        /*
         * Shared modules
         */
            "app.core",
            "app.blocks",
            "app.layout",
            "app.services",
        /*
         * Feature areas
         */
            "app.admin",
            "app.categories",
            "app.posts"
        ]);
})();