# O módulo do Azure Powershell é necessário que esteja instalado no computador
# Também é necessário que as configurações seja executadas anteriormente
# Link de instalação: https://learn.microsoft.com/en-us/powershell/azure/install-azure-powershell?view=azps-10.2.0

# Valores Padrões
$defaultTenantId = "<Insira o Tenant Id>"                           # Substituicao
$defaultLocation = "<Insira a Regiao>"                              # Substituicao
$defaultResourceGroupName = "<Insira o Nome do Resource Group>"     # Substituicao
$defaultServerName = "<Insira o Nome do Server Name>"               # Substituicao
$defaultAdminLogin = "<Insira o Login para Admin>"                  # Substituicao
$defaultAdminPassword = "<Insira a Senha para o Login>"             # Substituicao
$defaultDatabaseName = "<Insira o nome do banco de dados>"          # Substituicao
$defaultCollation = "<Insira o Collation desejado>"                 # Substituicao
$defaultEdition = "<Insira a Edição das Máquinas>"                  # Substituicao
$defaultFamily = "<Insira a Geração da Familia de Máquinas>"        # Substituicao
$defaultCapacity = <Insira numeros de cores>                        # Substituicao
$defaultBackupStorageRedundancy = "<Insira a Localizacao do Backup>"# Substituicao
$defaultPublicEndpointEnabled = "Enabled"                           # Substituicao

# Input dos parâmetros para processar
$tenantId = Read-Host "Entre com o Tenant Id: [$($defaultTenantId)]"
$tenantId = ($defaultTenantId, $tenantId)[[bool]$tenantId]

$location = Read-Host "Entre com o Location: [$($defaultLocation)]"
$location = ($defaultLocation, $location)[[bool]$location]

$resourceGroupName = Read-Host "Entre com o Resource Group: [$($defaultResourceGroupName)]"
$resourceGroupName = ($defaultResourceGroupName, $resourceGroupName)[[bool]$resourceGroupName]

$serverName = Read-Host "Entre com o Server Name: [$($defaultServerName)]"
$serverName = ($defaultServerName, $serverName)[[bool]$serverName]

$adminLogin = Read-Host "Entre com o Admin Login: [$($defaultAdminLogin)]"
$adminLogin = ($defaultAdminLogin, $adminLogin)[[bool]$adminLogin]

$adminPassword = Read-Host "Entre com o Admin Password: [$($defaultAdminPassword)]"
$adminPassword = ($defaultAdminPassword, $adminPassword)[[bool]$adminPassword]

$databaseName = Read-Host "Entre com o Database Name: [$($defaultDatabaseName)]"
$databaseName = ($defaultDatabaseName, $databaseName)[[bool]$databaseName]

$collation = Read-Host "Entre com o Collation: [$($defaultCollation)]"
$collation = ($defaultCollation, $collation)[[bool]$collation]

$edition = Read-Host "Entre com o Edition: [$($defaultEdition)]"
$edition = ($defaultEdition, $edition)[[bool]$edition]

$family = Read-Host "Entre com o Family: [$($defaultFamily)]"
$family = ($defaultFamily, $family)[[bool]$family]

$capacity = Read-Host "Entre com o Capacity: [$($defaultCapacity)]"
$capacity = ($defaultCapacity, $capacity)[[bool]$capacity]

# Valores mantidos
$backupStorageRedundancy = $defaultBackupStorageRedundancy
$publicEndpointEnabled = $defaultPublicEndpointEnabled

# Conectar à sua conta do Azure
Connect-AzAccount

# Criar um grupo de recursos
Write-Host "Criando o Resource Group"
New-AzResourceGroup -Name $resourceGroupName -Location $location

# Criar um servidor SQL
Write-Host "Criando o Servidor"
New-AzSqlServer -ResourceGroupName $resourceGroupName -ServerName $serverName -Location $location -SqlAdministratorCredentials $(New-Object -TypeName System.Management.Automation.PSCredential -ArgumentList $adminLogin, $(ConvertTo-SecureString -String $adminPassword -AsPlainText -Force)) -ServerVersion "12.0" -PublicNetworkAccess $publicEndpointEnabled

# Criar o Banco de dados
Write-Host "Criando o Banco de dados"
New-AzSqlDatabase -ResourceGroupName $resourceGroupName -ServerName $serverName -DatabaseName $databaseName -Edition $edition -BackupStorageRedundancy $backupStorageRedundancy -ComputeGeneration $defaultFamily -VCore $defaultCapacity -Collation $collation

# Finalizacao
Write-Host "Processo concluído com sucesso !"



