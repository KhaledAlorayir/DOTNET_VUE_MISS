<script setup lang="ts">
defineProps<{
  msg: string;
  d7om: () => void;
}>();
</script>

<template>
  <p>{{ msg }}</p>
</template>
