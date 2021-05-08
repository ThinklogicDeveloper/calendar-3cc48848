module.exports = {
  lintOnSave: !(process.env.NODE_ENV === "production"),
  pluginOptions: {
    env: {
      ENVIRONMENT: process.env.ENVIRONMENT,
      API: process.env.API,
      FRONT_END: process.env.FRONT_END,
    },
  },
  transpileDependencies: [/node_modules[/\\\\]vuetify[/\\\\]/, "vuetify"],
};
