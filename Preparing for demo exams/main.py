import numpy as np
import pandas as pd

df = pd.read_csv('telecom_churn.csv')
pd.set_option('display.max_rows', None)
pd.set_option('display.max_columns', None)
pd.set_option('display.max_colwidth', None)
print(df.info())
#pd.set_option('display.max_columns', 100)
#pd.set_option('display.max_rows', 100)
print(df.head())
#print(df["Number vmail messages"].sum(), df["Number vmail messages"].mean(), df["Number vmail messages"].max())
#print(df["State"].mode())
print(df['Churn'].mode())