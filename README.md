## Run generative AI models with ONNX Runtime C# demo

<img width="1013" height="773" alt="image" src="https://github.com/user-attachments/assets/9ea8ad61-397c-490c-967d-986009ef53ec" />


### Download the model directly using the Hugging Face CLI
```bash

huggingface-cli download onnxruntime/DeepSeek-R1-Distill-ONNX --include deepseek-r1-distill-qwen-1.5B/cpu_and_mobile/* --local-dir .

```

### For CUDA:

```bash

ConsoleDeepSeek.exe -m C:\deeplearning\huggingface\models\deepseek-r1-distill-qwen-1.5B\gpu\gpu-int4-rtn-block-32 -e cuda

```

### For DirectML:

```bash

ConsoleDeepSeek.exe -m C:\deeplearning\huggingface\models\deepseek-r1-distill-qwen-1.5B\gpu\gpu-int4-rtn-block-32 -e dml

```

### Export Hugging Face Models to ONNX
Hugging Face provides many options for exporting models to ONNX, including an ONNX Export Space for PyTorch models from the Hugging Face Model Hub.

[Export PyTorch models to ONNX →](https://huggingface.co/spaces/onnx/export)

[Other ONNX export options →](https://huggingface.co/docs/transformers/serialization)
