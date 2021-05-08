import http from "@/services/Http";

const resource = "calendar";

export default {
  create(args) {
    return http.post(`/${resource}/create-event`, args);
  },
};
