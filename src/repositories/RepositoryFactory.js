import DefaultRepository from "./DefaultRepository";

const repositories = {
  DefaultRepository: DefaultRepository,
};

export default {
  get: (repository) => repositories[repository],
};
