import http from "@/services/Http";

const resource = "calendar";

export default {
  create(args) {
    return http.post(`${process.env.API}/${resource}/create-event`, args);
  },
};
