<script setup lang="ts">
import { onMounted, ref } from "vue";
import ButtonCustom from "./ButtonCustom.vue";

interface Customer {
  id: number;
  firstname: string;
  lastname: string;
  pets: Pet[];
}

interface Pet {
  id: number;
  name: string;
  type: string;
}

const customers = ref<Customer[]>([]);

onMounted(async () => {
  const response = await fetch("http://localhost:5000/api/customers");
  const data = (await response.json()) as Customer[];
  customers.value = data;
});

function hello() {
  console.log("ssss");
}
</script>

<template>
  <ButtonCustom :d7om="hello" msg="hello" />
  <ul v-for="customer in customers" :key="customer.id">
    <li>{{ customer.lastname }}</li>
  </ul>
</template>

<style scoped></style>
