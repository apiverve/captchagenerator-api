from setuptools import setup, find_packages

import os
lib_folder = os.path.dirname(os.path.realpath(__file__))
requirements_file = os.path.join(lib_folder, 'requirements.txt')
install_requires = ["requests >= 2.25.1", "setuptools >= 56.0.0"]
if os.path.exists(requirements_file):
    with open(requirements_file, 'r') as f:
        install_requires = f.read().splitlines()

setup(
    name='apiverve_captchagenerator',
    version='1.2.6',
    packages=find_packages(),
    include_package_data=True,
    install_requires=install_requires,
    description='Captcha Generator creates a new captcha on every call: distorted characters or a simple math question as a GIF or PNG, with the answer to check on your server. Add audio=true for a spoken version, the accessible alternative for visitors who can't see the image.',
    author='APIVerve',
    author_email='hello@apiverve.com',
    url='https://apiverve.com/marketplace/captchagenerator?utm_source=pypi&utm_medium=referral&utm_content=homepage',
    classifiers=[
        'Programming Language :: Python :: 3',
        'Operating System :: OS Independent',
    ],
    python_requires='>=3.6',
)