((): void => {
    angular
        .module("app.posts")
        .controller("PostsPublishedController", postsPublishedController);

    function postsPublishedController(): void {
        var vm = this;
        
        this.test = "Post Partial With Binding";
    }

})(); 