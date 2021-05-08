import CalendarRepository from "./CalendarRepository";

const repositories = {
  CalendarRepository: CalendarRepository,
};

export default {
  get: (repository) => repositories[repository],
};
