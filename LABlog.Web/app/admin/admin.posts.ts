module app.admin.posts {
    "use strict";

    interface IPostsController {
        createPost(): void;
        getAllPosts(): ng.IPromise<IPost>
    }

    export interface IPost {
        id: number;
        title: string;
        body: string;
        abstract: string;
        postedBy: string;
        created: string;
        published: boolean;
        categoryId: number;
    }


    class CreatePostController implements IPostsController {

        constructor() {
            var vm = this;
        }

        createPost(): void { }

        getAllPosts(): ng.IPromise<IPost> {
            throw new EventException();
        }

    }

    angular.module("app.admin").controller("app.admin.posts.CreatePostController", CreatePostController);
}