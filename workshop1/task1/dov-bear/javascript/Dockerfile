## Build the image
ARG VER=18.2.0

FROM node:${VER}

LABEL developer=chuk

# create a working directory
WORKDIR /app

# make sure that curl is installed in container
RUN apt update && apt install curl

# copy files from local into container
ADD package.json .
ADD package-lock.json .
ADD .gitignore .
ADD public public
ADD views views
ADD main.js .

# install packages
RUN npm ci

## Run the image
ENV APP_PORT=3000
ENV INSTANCE_NAME="Dov Bear in JavaScript"

EXPOSE ${APP_PORT}

HEALTHCHECK --interval=30s --timeout=5s --retries=3 \
  CMD curl -s http://localhost:${APP_PORT}/healthz || exit 1

# run the application
ENTRYPOINT [ "node", "main.js" ]