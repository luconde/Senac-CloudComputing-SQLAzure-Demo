# O módulo do Azure Powershell é necessário que esteja instalado no computador
# Também é necessário que as configurações seja executadas anteriormente
# Link de instalação: https://learn.microsoft.com/en-us/powershell/azure/install-azure-powershell?view=azps-10.2.0

# Valores Padroes
$defaultTenantId = "<Insira o Tenant Id>"                           # Substituicao
$defaultResourceGroupName = "<Insira o Nome do Resource Group>"     # Substituicao                  
$defaultServerName = "<Insira o Nome do Server Name>"               # Substituicao
$defaultDatabaseName = "<Insira o nome do banco de dados>"          # Substituicao

# Input dos parâmetros para processar
$tenantId = Read-Host "Entre com o Tenant Id: [$($defaultTenantId)]"
$tenantId = ($defaultTenantId, $tenantId)[[bool]$tenantId]

$resourceGroupName = Read-Host "Entre com o Resource Group: [$($defaultResourceGroupName)]"
$resourceGroupName = ($defaultResourceGroupName, $resourceGroupName)[[bool]$resourceGroupName]

$serverName = Read-Host "Entre com o Server Name: [$($defaultServerName)]"
$serverName = ($defaultServerName, $serverName)[[bool]$serverName]

$databaseName = Read-Host "Entre com o Database Name: [$($defaultDatabaseName)]"
$databaseName = ($defaultDatabaseName, $databaseName)[[bool]$databaseName]

# Conectar à sua conta do Azure (faça login se necessário)
Connect-AzAccount -TenantId $tenantId

# Excluir o banco de dados
Write-Host "Apagando o Banco de dados"
Remove-AzSqlDatabase -ResourceGroupName $resourceGroupName -ServerName $serverName -DatabaseName $databaseName -Force

# Excluir o servidor (opcional, se você deseja excluir o servidor também)
Write-Host "Apagando o Servidor"
Remove-AzSqlServer -ResourceGroupName $resourceGroupName -ServerName $serverName -Force

# Excluir o grupo de recursos
Write-Host "Apagando o Resource Group"
Remove-AzResourceGroup -Name $resourceGroupName -Force

# Finalizacao
Write-Host "Processo concluído com sucesso !"
