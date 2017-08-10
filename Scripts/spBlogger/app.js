angular.module('spBlogger', ['spBlogger.posts', 'spBlogger.posts.controllers', 'spBlogger.posts.services', 'spBlogger.admin', 'spBlogger.admin.controllers', 'spBlogger.admin.services', 'ui.router', 'ngResource']);

//angular.module('spBlogger', ['ui.router']);

angular.module('spBlogger').run(['$state', function ($state) {
    $state.go('allPosts');
}]);