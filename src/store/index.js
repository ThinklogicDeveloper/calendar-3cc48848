import Vue from "vue";
import Vuex from "vuex";
import VuexPersistedState from "vuex-persistedstate";
import modules from "./modules";

Vue.use(Vuex);

export default new Vuex.Store({
  strict: process.env.ENVIRONMENT !== "production",
  modules,
  plugins: [
    VuexPersistedState({
      storage: window.sessionStorage,
    }),
  ],
});
