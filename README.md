# url-shortner

## Infrastructure as Code

### Download Azure CLI

https://aka.ms/installazurecliwindows

### Log in into Azure

```bash
az login
```

### Create Resource Group

```bash
az group create --name urlshortner-[dev | stg | prod] --location eastus2
```

Listing locations

```bash
az account list-locations
```

Create resources

```bash
az deployment group create --resource-group urlshortner-dev --template-file .\infrastructure\main.bicep
```