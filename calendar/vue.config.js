module.exports = {
  lintOnSave: !(process.env.NODE_ENV === "production"),
  pluginOptions: {
    env: {
      FRONT_END: process.env.FRONT_END,
      ENVIRONMENT: process.env.ENVIRONMENT,
    },
  },
  transpileDependencies: [/node_modules[/\\\\]vuetify[/\\\\]/, "vuetify"],
};
