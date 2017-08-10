angular.module('spBlogger.posts', ['ui.router']).config(['$stateProvider', '$locationProvider', function ($stateProvider, $locationProvider) {
    $stateProvider.state('allPosts', {
        url: '/posts',
        templateUrl: 'Partials/posts/posts.html',
        controller: 'PostController'
    });
    $stateProvider.state('singlePost', {
        url: '/posts/:id/:permalink',
        templateUrl: 'Partials/posts/singlePost.html',
        controller: 'PostDetailsController'
    });
}]);