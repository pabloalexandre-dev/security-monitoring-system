# 🛡️ Security Monitoring System (Projeto de Estudos)

## 📌 Descrição
Este é um projeto de estudos voltado para **segurança e monitoramento** de autenticação simples, simulando um ambiente SOC (Security Operations Center).  

O foco principal do projeto foi:  
- Validar **login de administrador**  
- Registrar tentativas de login e falhas em **logs**  
- Criar uma estrutura limpa de código C# para estudos de segurança e práticas de SOC  

> ⚠️ Este projeto **não é para produção**, apenas para estudo e demonstração.

---

## 🔑 Funcionalidades

1. **Autenticação Admin**  
   - Username: `Admin`  
   - Password: `123456`  
   - Validação direta no formulário  

2. **Validação de login**  
   - Tentativas incorretas geram mensagem de erro  
   - Tentativas corretas liberam acesso ao sistema  

3. **Registro de Logs**  
   - Todas as tentativas (corretas ou incorretas) são capturadas em **logs de terminal**  
   - Logs podem ser visualizados e analisados como faria um SOC  

---

## 📁 Estrutura do Projeto

## SecurityMonitoringSystem/
 - │── Forms/
 - │── Logs/
 - │── Program.cs
 - │── App.config
 - │── SecurityMonitoringSystem.sln
 - │── README.md
 - │── screens/
 - ├── autenticacao_concluida.png
 - ├── autenticacao_invalida.png
 - └── logs_terminal.png


- **Forms/** → Telas do sistema  
- **Logs/** → Logs internos (se houver gravação em arquivo)  
- **screens/** → Prints para README (capturas de login e logs)  

---

## 🖼 Capturas do Sistema

### 1️⃣ Login correto

*Autenticação concluída com sucesso:*

![Autenticação Concluída](./screens/autenticacao_autorizada)

---

### 2️⃣ Login incorreto

*Tentativa de login inválida:*

![Autenticação Inválida](./screens/autenticacao_negada)

---

### 3️⃣ Logs do terminal

*Captura de todas as tentativas de login:*

![Logs](./screens/logs)

---

## 🛠 Tecnologias Utilizadas

- **C#** (.NET 10.0)  
- **Windows Forms**  
- **PowerShell / Terminal** para captura de logs  
- **Git/GitHub** para versionamento  

---
