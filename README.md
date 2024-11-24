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
az group create --name urlshortner-[dev | stg | prd] --location eastus2
```

Listing locations

```bash
az account list-locations
```

Create resources

```bash
az deployment group create --resource-group urlshortner-dev --template-file .\infrastructure\main.bicep
```


### Create User for GitHub Actions

```bash
az ad sp create-for-rbac --name "GitHub-Actions-SP" \
                         --role contributor \
                         --scopes /subscriptions/28c48ddb-bfa0-43e4-b7b4-ed7de0f35be3 \
                         --sdk-auth
```

We'll use the `clientId` and `tenantId`

#### Configure a federated identity credential on an app

https://learn.microsoft.com/en-us/entra/workload-id/workload-identity-federation-create-trust?pivots=identity-wif-apps-methods-azp#configure-a-federated-identity-credential-on-an-app