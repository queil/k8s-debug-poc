# k8s-debug-poc

Debugging .NET apps in Kubernetes with [Kuba](https://github.com/queil/kuba)

# Trying it out

Read [this](https://github.com/queil/kuba#try-it) first if you have not yet. 

1. Edit the Tiltfile line `allow_k8s_contexts('docker-desktop')` to match your Kubernetes cluster.
2. This particular Tiltfile uses the stand-alone [kustomize](https://kustomize.io/) to generate the app manifests. If you want to use it too please make sure you've got it [installed](https://github.com/kubernetes-sigs/kustomize/blob/master/docs/INSTALL.md).

# Resources

* Learn more about [tilt](https://docs.tilt.dev/)
