Vagrant.configure("2") do |config|
  # Definindo a box base (sistema operacional)
  config.vm.box = "ubuntu/focal64"
  
  # Definindo a VM1
  config.vm.define "vm1" do |vm1|
    vm1.vm.hostname = "vm1"
    vm1.vm.network "private_network", type: "static", ip: "192.168.56.10"  # IP fixo
    vm1.vm.provider "virtualbox" do |vb|
      vb.memory = "1024"
    end
  end

  # Definindo a VM2
  config.vm.define "vm2" do |vm2|
    vm2.vm.hostname = "vm2"
    vm2.vm.network "private_network", type: "static", ip: "192.168.56.11"  # IP fixo
    vm2.vm.provider "virtualbox" do |vb|
      vb.memory = "2048"
    end

    # Sincronizar pasta da aplicação
    vm2.vm.synced_folder "./vagrant_data", "/home/vagrant/app"

    vm2.vm.provision "shell", inline: <<-SHELL
      # Atualiza o sistema
      sudo apt-get update -y
      sudo apt-get install -y wget apt-transport-https software-properties-common

      # Adiciona o repositório da Microsoft para Ubuntu 20.04
      wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb
      sudo dpkg -i packages-microsoft-prod.deb
      rm packages-microsoft-prod.deb

      # Instala o .NET SDK 8
      sudo apt-get update -y
      sudo apt-get install -y dotnet-sdk-8.0 git

      # Verifica a instalação
      dotnet --version
    SHELL
  end
end
