FROM mcr.microsoft.com/mssql/server:2019-latest
WORKDIR app

COPY . .

ENV SA_PASSWORD SuperSA2020
ENV ACCEPT_EULA Y

ENTRYPOINT /bin/bash ./entrypoint.sh