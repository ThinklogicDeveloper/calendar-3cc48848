class CalendarEvent {
  constructor({
    id = 0,
    title = "",
    startDate = null,
    endDate = null,
    location = "",
    description = "",
  } = {}) {
    this.id = id;
    this.title = title;
    this.startDate = startDate;
    this.endDate = endDate;
    this.location = location;
    this.description = description;
  }
}

export default Object.freeze(CalendarEvent);
