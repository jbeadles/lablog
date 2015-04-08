module app.services {
    "use strict";

    export interface IPostService {
        getById(id: number): ng.IPromise<IPost>;
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

    export interface ICategory {
        id: number;
        name: string;
    }

    class PostService implements IPostService {

        static $inject = ["$http"];

        constructor(private $http: ng.IHttpService) {
            
        }

        getById(postId: number): ng.IPromise<IPost> {
            return this.$http.get("/api/posts/" + postId)
                .then((response: ng.IHttpPromiseCallbackArg<IPost>): IPost => {
                    return response.data;
                });
        }
    }

    angular.module("app.services")
        .factory("app.services.PostService", PostService);
} 