class CalendarEvent {
  constructor({
    id = 0,
    title = "",
    startTime = null,
    endTime = null,
    location = "",
    description = "",
  } = {}) {
    this.id = id;
    this.title = title;
    this.startTime = startTime;
    this.endTime = endTime;
    this.location = location;
    this.description = description;
  }
}

export default Object.freeze(CalendarEvent);
