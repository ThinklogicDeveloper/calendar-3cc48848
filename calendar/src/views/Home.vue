<template>
  <div>
    <v-sheet height="600">
      <v-calendar
        ref="calendar"
        v-model="value"
        :weekdays="weekday"
        :type="type"
        :events="events"
        :event-overlap-mode="mode"
        :event-overlap-threshold="30"
        :event-color="getEventColor"
        @change="getEvents"
        @click:date="selectedDate"
      ></v-calendar>
    </v-sheet>
    <event-dialog
      :dialog="dialog"
      @createEvent="createEvent"
      @cancelEvent="cancelEvent"
    ></event-dialog>
  </div>
</template>

<script>
import EventDialog from "@/components/Event";
import RepositoryFactory from "@/repositories/RepositoryFactory";

const CalendarRepository = RepositoryFactory.get("CalendarRepository");

export default {
  components: {
    EventDialog,
  },
  data: () => ({
    dialog: false,
    type: "month",
    types: ["month", "week", "day", "4day"],
    mode: "stack",
    modes: ["stack", "column"],
    weekday: [0, 1, 2, 3, 4, 5, 6],
    weekdays: [
      { text: "Sun - Sat", value: [0, 1, 2, 3, 4, 5, 6] },
      { text: "Mon - Sun", value: [1, 2, 3, 4, 5, 6, 0] },
      { text: "Mon - Fri", value: [1, 2, 3, 4, 5] },
      { text: "Mon, Wed, Fri", value: [1, 3, 5] },
    ],
    value: "",
    events: [],
    colors: [
      "blue",
      "indigo",
      "deep-purple",
      "cyan",
      "green",
      "orange",
      "grey darken-1",
    ],
    names: [
      "Meeting",
      "Holiday",
      "PTO",
      "Travel",
      "Event",
      "Birthday",
      "Conference",
      "Party",
    ],
  }),
  methods: {
    selectedDate(args) {
      this.dialog = true;
      console.log(args);
    },
    createEvent(args) {
      try {
        console.log(args);
        const { response } = CalendarRepository.create(args);
      } catch (e) {
        console.log(e);
      }
    },
    cancelEvent() {
      this.dialog = false;
    },
    getEvents({ start, end }) {},
    getEventColor(event) {
      return event.color;
    },
    rnd(a, b) {
      return Math.floor((b - a + 1) * Math.random()) + a;
    },
  },
};
</script>
