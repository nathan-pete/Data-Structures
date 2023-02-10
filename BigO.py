import random
import time

s = time.time()
## 0(1) Constant
arrayZero = [1,2,3,4,5]

def bigoZero(arr, index):
    return arr[index]

print("Big O Constant: " + str(bigoZero(arrayZero, 4)))

## 0(n) Linear
arrayLinear = [1,2,3,4,5] 
num = random.randint(0, 4)

def bigoLinear(arrayLinear):
    for i in arrayLinear:
      if i == num:
        print(i)
    return arrayLinear[arrayLinear.index(num)]

print("Big O Linear: " + str(bigoLinear(arrayLinear)))

## 0(n^2) Quadratic
arrayQuadratic = [1,2,3,4,5]

def bigoQuadratic(arr):
  for i in range(len(arr)):
    for j in range(len(arr)):
      print(arr[i], arr[j])

bigoQuadratic([1, 2, 3, 4])

## 0(n log n) Log Linear
arr = [1,2,3,4,5]


def bigOnlogn(arr) :
    if len(arr) <= 1:
        return arr
    sorted_arr = arr.copy()
    mid = len(sorted_arr) // 2
    L = sorted_arr[:mid]
    R = sorted_arr[mid:]
    L = bigOnlogn(L)
    R = bigOnlogn(R)
    i = j = k = 0
    while i < len(L) and j < len(R):
        if L[i] < R[j]:
            sorted_arr[k] = L[i]
            i += 1
        else:
            sorted_arr[k] = R[j]
            j += 1
        k += 1
    while i < len(L):
        sorted_arr[k] = L[i]
        i += 1
        k += 1
    while j < len(R):
        sorted_arr[k] = R[j]
        j += 1
        k += 1
    return sorted_arr

print("Big O n long n: " + bigOnlogn())

e = time.time()
print("Total Time: " + str(e-s))
