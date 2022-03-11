import { createApp } from "vue";
import ElementPlus from "element-plus";
import "element-plus/dist/index.css";
import App from "./App.vue";
import router from "./router";
import store from "./store";
import axios from "axios";
import VueAxios from "vue-axios";

const app = createApp(App)
  .use(ElementPlus, { size: "small", zIndex: 3000 })
  .use(store)
  .use(router)
  .use(VueAxios, axios);
app.provide("axios", app.config.globalProperties.axios);
app.mount("#app");
