FROM node:lts-alpine
WORKDIR /app
COPY package.json ./
COPY package-lock.json ./
RUN npm i
EXPOSE 8080
CMD ["npm", "run", "serve"]