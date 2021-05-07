export const loadView = (component) => {
  return import(/* webpackChunkName: "[request]" */ `@/${component}.vue`);
};
