# Microservice Kubernetes Demo
A simple Asp.Net Core API project with EF Core and Sql server, running on Kubernetes (AWS EKS / local Docker desktop environment)

## Prerequisites to run Kubernetes locally on Docker Desktop (Linux containers on Windows)
- Ensure you have Docker desktop installed (https://www.docker.com/products/docker-desktop)
- Switch to **Linux** containers from the Docker taskbar icon (If you see the option "Switch to Windows containers", that means it's already set to Linux containers so skip this step)
- Enable Kubernetes in Docker desktop
![](images/docker-desktop-kube.png)
- Ensure your kubernetes context is set to docker desktop (to run it locally). Click on the Docker taskbar icon, hover over "kubernetes" menu item and select "Docker desktop". You will see the AWS context once that is setup, more on that later.
- If everything's fine, run the kubectl version command and it should display the kubernetes version information
```
> kubectl version
```
- Setup the Kubernetes dashboard. Follow the steps provided on https://kubernetes.io/docs/tasks/access-application-cluster/web-ui-dashboard/ to set it up. You can stop at the "Welcome View" step for now to keep it short, more details on deploying containerized application is provided below
- The Kubernetes dashboard will ask you to login. Run the below command to get the admin bearer token, copy the token and paste it on the login screen to login
```
> kubectl -n kubernetes-dashboard describe secret $(kubectl -n kubernetes-dashboard get secret | sls admin-user | ForEach-Object { $_ -Split '\s+' } | Select -First 1)
```
![](images/kube-dashboard-login.png)