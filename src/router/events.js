import router from "./index";

router.beforeEach((to, from, next) => {
  // do beforeEach event process
  next();
});
