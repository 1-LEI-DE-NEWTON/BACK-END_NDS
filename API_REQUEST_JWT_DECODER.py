
import pip._vendor.requests
import jwt
import json
import sys

def intranet_Return_Pessoa_Tipo_Id (username, password):

    # URL do endpoint de autenticação da API
    url = 'https://your-auth-api/auth'

    # Corpo da requisição, com o usuário e senha
    http_POST_body_data = {"username": username, "password": password}

    # Envia um request POST para a API, com o corpo da requisição em formato JSON
    API_jwt_body_response = pip._vendor.requests.post(url, json = http_POST_body_data)
    
    # Verifica se o status code da resposta não é 200 (OK)
    if API_jwt_body_response.status_code != 200:
        print('Erro ao autenticar no sistema. Status code: ' + str(API_jwt_body_response.status_code))
        return 0
    
    # Carrega o JSON de resposta em uma variável
    API_body_response_data = json.loads(API_jwt_body_response.text)

    # Extrai o token JWT da resposta
    API_jwt_token = API_body_response_data['token']

    # Decodifica o token JWT
    decoded = jwt.decode(API_jwt_token, options={"verify_signature": False})

    # Extrai o email do token JWT decodificado e salva em uma variável
    email_from_JSON = decoded['email']

    # Retorna o email
    return email_from_JSON

# Recebe os argumentos passados (nome de usuario e senha) pela linha de comando
username = sys.argv[1]
password = sys.argv[2]

# Chama a função e passa os argumentos
intranet_Return_Pessoa_Tipo_Id('username', 'password')
