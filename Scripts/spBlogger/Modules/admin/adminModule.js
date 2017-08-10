angular.module('spBlogger.admin', ['ui.router']).config(['$stateProvider', function ($stateProvider) {
    $stateProvider.state('admin', {
        url: '/admin',
        abstract: true,
        controller: 'AdminController',
        templateUrl: 'Partials/admin/admin-home.html'
    }).state('admin.postNew', {
        url: '/posts/new',
        controller: 'PostCreationController',
        templateUrl: 'Partials/admin/admin-new-post.html'
    }).state('admin.postUpdate', {
        url: '/posts/:id/edit',
        controller: 'PostUpdateController',
        templateUrl: 'Partials/admin/admin-update-post.html'
    }).state('admin.postViewAll', {
        url: '',
        controller: 'PostListController',
        templateUrl: 'Partials/admin/admin-all-posts.html'
    });
}]);