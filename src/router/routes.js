import { loadView } from "@/services/Helpers";

export default [
  {
    path: "/",
    name: "Home",
    component: () => loadView("views/Home"),
  },
  {
    path: "/about",
    name: "About",
    component: () => loadView("views/About"),
  },
];
