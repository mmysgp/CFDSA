## 1st builder container with a name builder
FROM golang:alpine3.16 AS builder

LABEL org.opencontainers.image.source=https://github.com/mmysgp/CFDSA

WORKDIR /app

ADD go.mod .
ADD go.sum .
ADD main.go .

# produce the binary main (executable)
RUN go build -o main main.go

## 2nd container for app
FROM alpine:3.16

WORKDIR /app

COPY --from=builder /app/main main

ADD public public
ADD templates templates

ENV PORT=3000
EXPOSE ${PORT}

ENTRYPOINT [ "./main" ]