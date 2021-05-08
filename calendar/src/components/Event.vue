<template>
  <v-dialog v-model="dialog" width="1000" persistent>
    <v-card>
      <v-card-title class="headline grey lighten-2"> Add Event </v-card-title>

      <v-card-text>
        <v-row>
          <v-col cols="12" sm="6" md="4">
            <v-text-field
              label="Title"
              v-model="calendarEvent.title"
            ></v-text-field>
          </v-col>

          <v-col cols="12" sm="6" md="4">
            <v-dialog
              ref="dialog"
              v-model="modal2"
              :return-value.sync="time"
              persistent
              width="290px"
            >
              <template v-slot:activator="{ on, attrs }">
                <v-text-field
                  v-model="time"
                  label="Start Time"
                  prepend-icon="mdi-clock-time-four-outline"
                  readonly
                  v-bind="attrs"
                  v-on="on"
                ></v-text-field>
              </template>
              <v-time-picker
                v-if="modal2"
                v-model="calendarEvent.startTime"
                full-width
              >
                <v-spacer></v-spacer>
                <v-btn text color="primary" @click="modal2 = false">
                  Cancel
                </v-btn>
                <v-btn text color="primary" @click="$refs.dialog.save(time)">
                  OK
                </v-btn>
              </v-time-picker>
            </v-dialog>
          </v-col>

          <v-col cols="12" sm="6" md="4">
            <v-dialog
              ref="dialog"
              v-model="modal2"
              :return-value.sync="time"
              persistent
              width="290px"
            >
              <template v-slot:activator="{ on, attrs }">
                <v-text-field
                  v-model="time"
                  label="Start Time"
                  prepend-icon="mdi-clock-time-four-outline"
                  readonly
                  v-bind="attrs"
                  v-on="on"
                ></v-text-field>
              </template>
              <v-time-picker
                v-if="modal2"
                v-model="calendarEvent.endTime"
                full-width
              >
                <v-spacer></v-spacer>
                <v-btn text color="primary" @click="modal2 = false">
                  Cancel
                </v-btn>
                <v-btn text color="primary" @click="$refs.dialog.save(time)">
                  OK
                </v-btn>
              </v-time-picker>
            </v-dialog>
          </v-col>

          <v-col cols="12" sm="6" md="6">
            <v-text-field
              label="Description"
              v-model="calendarEvent.description"
            ></v-text-field>
          </v-col>

          <v-col cols="12" sm="6" md="6">
            <v-text-field
              label="Location"
              v-model="calendarEvent.location"
            ></v-text-field>
          </v-col>
        </v-row>
      </v-card-text>

      <v-divider></v-divider>

      <v-card-actions>
        <v-spacer></v-spacer>
        <v-btn
          color="primary"
          text
          @click="$emit(`createEvent`, calendarEvent)"
        >
          Create Event
        </v-btn>
        <v-btn color="default" text @click="$emit(`cancelEvent`)">
          Cancel
        </v-btn>
      </v-card-actions>
    </v-card>
  </v-dialog>
</template>

<script>
import CalendarEvent from "@/models/CalendarEvent";
import RepositoryFactory from "@/repositories/RepositoryFactory";
const CalendarRepository = RepositoryFactory.get("CalendarRepository");

export default {
  data: () => ({
    calendarEvent: new CalendarEvent(),
    time: null,
    menu2: false,
    modal2: false,
  }),
  props: {
    dialog: {
      type: Boolean,
      required: true,
      default: () => {
        return false;
      },
    },
  },
};
</script>
