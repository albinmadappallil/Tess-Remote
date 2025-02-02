FROM ubuntu:focal

EXPOSE 5000

ENV ASPNETCORE_ENVIRONMENT="Production"
ENV ASPNETCORE_URLS="http://*:5000"

RUN \
  apt-get -y update && \
  apt-get -y install \
  apt-utils \
  wget \
  apt-transport-https \
  unzip \
  acl \
  libssl1.0

RUN \
  wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb && \
  dpkg -i packages-microsoft-prod.deb && \
  apt-get -y update && \
  apt-get -y install aspnetcore-runtime-5.0

RUN \
  mkdir -p /var/www/Tess && \
  mkdir /config && \
  wget -q https://github.com/lucent-sea/Tess/releases/latest/download/Tess_Server_Linux-x64.zip && \
  unzip -o Tess_Server_Linux-x64.zip -d /var/www/Tess && \
  rm Tess_Server_Linux-x64.zip

RUN \
  mkdir -p /Tess-data && \
  sed -i 's/DataSource=Tess.db/DataSource=\/Tess-data\/Tess.db/' /var/www/Tess/appsettings.json

VOLUME "/Tess-data"

WORKDIR /var/www/Tess

COPY DockerMain.sh /

RUN chmod 755 /DockerMain.sh

ENTRYPOINT ["/DockerMain.sh"]