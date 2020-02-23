allow_k8s_contexts('docker-desktop')
k8s_yaml(kustomize('./dev/k8s'))

docker_build('quay.io/queil/k8s-debug-poc', 
                './dev',
                live_update=[
                    sync('./dev/bin', '/app')
                ])
